using ConlluObject.Tokenization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class Form1 : Form
	{
		public static Paragraph Paragraph = new Paragraph();

		public Form1()
		{
			InitializeComponent();
		}

		private void init_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				Paragraph.InitFromBinFile(ofd.FileName);
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			var temp = new List<Token>();

			foreach (var Sentences in Paragraph.Sentences)
			{
				foreach (var t in Sentences.Tokens)
				{
					if (t.Upostag == ConlluObject.SpeechCategories.Pron)
					{
						temp.Add(t);

					}
				}
			}

			var all = string.Join(Environment.NewLine, temp.GroupBy(t=>t.Form.ToLower()).OrderBy(t => t.Count()).Select(t => string.Format("{0} - {1}", t.Key, t.Count())));

			var allLems = string.Join(Environment.NewLine, temp.GroupBy(t => t.Lemma.ToLower()).OrderBy(t=> t.Count()).Select(t => string.Format("{0} - {1}", t.Key, t.Count())));

			MessageBox.Show(all);
			MessageBox.Show(allLems);
		}
	}
}
