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
	}
}
