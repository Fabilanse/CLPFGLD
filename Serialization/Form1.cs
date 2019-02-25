using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IronPython.Hosting;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ConlluObject.Tokenization;

namespace Serialization
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.ShowDialog();

			var fileName = ofd.FileName;

			FileStream stream2 = File.OpenRead(fileName);

			var formatter = new BinaryFormatter();
			var v = (List<Token>)formatter.Deserialize(stream2);
			stream2.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var engine = Python.CreateEngine();
			var paths = engine.GetSearchPaths();

			paths.Add(Properties.Resources.IronPythonLibPath);
			paths.Add(string.Format(@"{0}\site-packages", Properties.Resources.IronPythonLibPath));

			engine.SetSearchPaths(paths);

			var a = engine.ExecuteFile(Properties.Resources.PythonExecuteFile);

			var sentences = a.GetVariable("sentences");

			var tokensList = new List<Token>();
			foreach (var tokens in sentences)
			{
				foreach (var t in tokens)
				{
					var item = new Token(t);
					tokensList.Add(item);
				}
			}

			var ofd = new OpenFileDialog();
			ofd.ShowDialog();

			var fileName = ofd.FileName;

			FileStream stream = File.Create(fileName);
			var formatter = new BinaryFormatter();
			formatter.Serialize(stream, tokensList);
			stream.Close();
		}
	}
}
