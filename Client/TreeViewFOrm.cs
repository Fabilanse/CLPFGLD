using ConlluObject.Tokenization;
using System.Collections.Generic;
using System.Windows.Forms;
using ConlluObject.Tools.TreeBuilder;

namespace Client
{
	public partial class TreeViewForm : Form
	{
		public TreeViewForm(Sentence sentence)
		{
			InitializeComponent();

			var conlluTreeBuilder = new ConlluTreeBuilder(new List<Sentence> { sentence });

			var conlluTree = conlluTreeBuilder.BuildTree();

			passConlluTree(tree.Nodes, conlluTree);
		}

		/// <summary>
		/// Обойти конлу дерево
		/// </summary>
		/// <param name="tree">Ноды элемента на вин форме</param>
		/// <param name="childs">Ноды конлу дерева</param>
		private void passConlluTree(TreeNodeCollection tree, List<ConlluNode> childs)
		{
			foreach (var child in childs)
			{
				var newNode = new TreeNode(child.Text);
				tree.Add(newNode);
				passConlluTree(newNode.Nodes, child.Childs);
			}
		}
	}
}
