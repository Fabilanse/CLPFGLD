using ConlluObject.Tokenization;
using System.Collections.Generic;
using System.Windows.Forms;
using ConlluObject.Tools.TreeBuilder;

namespace Client
{
	public partial class TreeViewForm : Form
	{
		public TreeViewForm(List<Sentence> sentences)
		{
			InitializeComponent();

			var conlluTreeBuilder = new ConlluTreeBuilder(sentences);

			var conlluTree = conlluTreeBuilder.BuildTree();

			conlluTreeBuilder.PassConlluTree(tree.Nodes, conlluTree);
		}
	}
}
