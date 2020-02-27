using ConlluObject.Tokenization;
using ConlluObject.Tools.TreeBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class MainForm : Form
	{
		public static Paragraph Paragraph = new Paragraph();

		public MainForm()
		{
			InitializeComponent();
		}

		private string fimeName = "";

		private async void init_Click(object sender, EventArgs e)
		{
			var progress = new Progress<int>(v =>
			{
				progressBar1.Value = v;
			});

			var ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				fimeName = ofd.FileName;
				await Task.Run(() =>
				{
					Paragraph.InitFromBinFile(fimeName, progress);

					foreach (var sentence in Paragraph.Sentences)
					{
						sentence.InitSentenceTokenReferences();
					}
				});
				progressBar1.Value = 0;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			var pronList = new List<Token>();
			foreach (var Sentences in Paragraph.Sentences)
			{
				foreach (var token in Sentences.Tokens)
				{
					if (token.Upostag == ConlluObject.SpeechCategories.Pron)
					{
						pronList.Add(token);
					}
				}
			}

			var all = string.Join(Environment.NewLine, pronList.GroupBy(t=>t.Form.ToLower()).OrderBy(t => t.Count()).Select(t => string.Format("{0} - {1}", t.Key, t.Count())));

			var allLems = string.Join(Environment.NewLine, pronList.GroupBy(t => t.Lemma.ToLower()).OrderBy(t=> t.Count()).Select(t => string.Format("{0} - {1}", t.Key, t.Count())));

			MessageBox.Show(all);
			MessageBox.Show(allLems);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.ShowDialog();

			var fileName = ofd.FileName;

			FileStream stream2 = File.OpenRead(fileName);

			var formatter = new BinaryFormatter();
			var listBox1Items = (string[])formatter.Deserialize(stream2);

			listBox1.Items.Clear();
			listBox1.Items.AddRange(listBox1Items);
			stream2.Close();
		}

		private List<LinkLabel> _createdLabels = new List<LinkLabel>();

		private Dictionary<int, Token> _labelTokenReferences = new Dictionary<int, Token>();

		private LinkLabel _dragableLabel = null;

		private int _fromIndex = 1;
		private int _toIndex = 15;
		private int _steep = 2;

		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (var linckLabel in Controls.OfType<LinkLabel>())
				{
					Controls.Remove(linckLabel);
				}
				foreach (var linckLabel in _createdLabels)
				{
					Controls.Remove(linckLabel);
				}

				var startX = 10;
				var startY = 70;

				var currentPoint = new Point(startX, startY);
				var g = this.CreateGraphics();

				var iterator = 1;
				foreach (var sentence in Paragraph.Sentences)
				{
					if (iterator < _fromIndex || iterator > _toIndex)
					{
						iterator++;
						continue;
					}

					sentence.Id = iterator;
					var lastHeight = 0;
					var tokenId = 0;
					foreach (var token in sentence.Tokens)
					{
						var tokenLabel = new LinkLabel();
						tokenLabel.Font = new Font("Arial", 12, FontStyle.Bold);
						tokenLabel.Text = string.Format("{2}{0}{1}", token.Form, token.Misc.SpaceAfter ? " " : string.Empty, tokenId == 0 ? string.Format("{0}) ", iterator) : string.Empty);

						tokenLabel.Location = currentPoint;

						var textSize = g.MeasureString(tokenLabel.Text, tokenLabel.Font);

						tokenLabel.Width = (int)textSize.Width + 5;
						tokenLabel.AllowDrop = true;

						tokenLabel.Height = (int)textSize.Height + 3;

						if (token.Upostag == ConlluObject.SpeechCategories.Pron)
						{
							tokenLabel.LinkColor = Color.Red;
						}

						var newX = tokenLabel.Location.X + (int)textSize.Width + 2;
						var newY = tokenLabel.Location.Y;
						if (newX >= this.Width - 400)
						{
							newY += (int)textSize.Height + 2;
							newX = startX;
						}

						lastHeight = (int)textSize.Height + 7;

						currentPoint = new Point(newX, newY);

						Controls.Add(tokenLabel);
						_createdLabels.Add(tokenLabel);
						_labelTokenReferences.Add(tokenLabel.GetHashCode(), token);

						tokenId++;

						tokenLabel.MouseDown += (s, eventArgs) =>
						{
							_dragableLabel = s as LinkLabel;

							if (eventArgs.Button == MouseButtons.Left)
							{
								_dragableLabel.DoDragDrop(token, DragDropEffects.Move);
							}
						};

						tokenLabel.DragEnter += (s, eventArgs) =>
						{
							if (eventArgs.Data.GetDataPresent(typeof(Token)))
							{
								eventArgs.Effect = DragDropEffects.Move;
							}
							else
							{
								eventArgs.Effect = DragDropEffects.None;
							}
						};

						tokenLabel.DragDrop += (s, eventArgs) =>
						{
							var target = _labelTokenReferences[(s as LinkLabel).GetHashCode()];

							var source = eventArgs.Data.GetData(typeof(Token)) as Token;

							if (source.Equals(target))
							{
								return;
							}

							// Собсно действие
							listBox1.Items.Add(string.Format("{2}.{0} -> {3}.{1}", source.Form, target.Form, source.Sentence.Id, target.Sentence.Id));
						};

						tokenLabel.MouseClick += (s, eventArgs) =>
						{
							if (eventArgs.Button == MouseButtons.Right)
							{
								var source = s as LinkLabel;
								var sourceObject = _labelTokenReferences[(s as LinkLabel).GetHashCode()];

								var treeViewForm = new TreeViewForm(new List<Sentence> { sourceObject.Sentence });
								treeViewForm.ShowDialog();
							}
						};

					}
					currentPoint = new Point(startX, currentPoint.Y + lastHeight);
					iterator++;
				}
			}
			catch(Exception error)
			{
				MessageBox.Show(error.Message);
			}

		}

		private void Forvard_Click(object sender, EventArgs e)
		{
			if (_fromIndex - _steep < 0)
			{
				_fromIndex = 0;
				_toIndex = _steep;
			}
			else
			{
				_fromIndex -= _steep;
				_toIndex -= _steep;
			}
			Button3_Click(sender, e);
		}

		private void Next_Click(object sender, EventArgs e)
		{
			if (Paragraph.Sentences.Count() <= _toIndex + _steep)
			{
				_fromIndex = Paragraph.Sentences.Count() -_steep;
				_toIndex = Paragraph.Sentences.Count();
			}
			else
			{
				_fromIndex += _steep;
				_toIndex += _steep;
			}
			Button3_Click(sender, e);
		}

		private void TextBoxSteep_TextChanged(object sender, EventArgs e)
		{
			var newSteep = 0;
			if (int.TryParse(textBoxSteep.Text, out newSteep))
			{
				_steep = newSteep;
			}
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			var ofd = new SaveFileDialog();
			ofd.ShowDialog();

			var fileName = ofd.FileName;

			if (string.IsNullOrEmpty(fileName))
			{
				return;
			}

			FileStream stream = File.Create(fileName);
			var formatter = new BinaryFormatter();

			var array = new string[listBox1.Items.Count];
			var i = 0;
			foreach (var item in listBox1.Items)
			{
				array[i++] = item.ToString();
			}

			formatter.Serialize(stream, array);
			stream.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Button7_Click(object sender, EventArgs e)
		{
			var index = listBox1.SelectedIndex;
			if (index >= 0)
			{
				listBox1.Items.RemoveAt(index);
				listBox1.SelectedIndex = index - 1 < 0 ? -1 : index - 1;
			}
		}

		private void viewAllTree_Click(object sender, EventArgs e)
		{
			var treeViewForm = new TreeViewForm(Paragraph.Sentences);
			treeViewForm.Show();
		}
	}
}
