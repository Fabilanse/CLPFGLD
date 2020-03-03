using ConlluObject.Tokenization;
using ConlluObject.Tools.TreeBuilder;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Client
{
	public partial class ReferenceCreator : Form
	{
		public ReferenceCreator(List<Sentence> sentences)
		{
			InitializeComponent();

			var conlluTreeBuilder = new ConlluTreeBuilder(sentences);

			conlluTreeBuilder.PassConlluTree(treeLeft.Nodes, conlluTreeBuilder.BuildTree());
			conlluTreeBuilder.PassConlluTree(treeRight.Nodes, conlluTreeBuilder.BuildTree());

			treeLeft.NodeMouseClick += (sender, e) =>
			{
				if (e.Button == MouseButtons.Right)
				{
					buildMenu(
						e,
						treeLeft, 
						(o, args) => 
						{
							var bindedObject = ((ConlluNode)e.Node).Sender;
							var clone = (ConlluNode)e.Node.Clone();
							clone.Sender = bindedObject;
							nounTree.Nodes.Add(clone);
						}, 
						(o, args) => 
						{
							var bindedObject = ((ConlluNode)e.Node).Sender;
							var clone = (ConlluNode)e.Node.Clone();
							clone.Sender = bindedObject;
							antecedentTree.Nodes.Add(clone);
						});
				}
			};

			treeRight.NodeMouseClick += (sender, e) =>
			{
				if (e.Button == MouseButtons.Right)
				{
					buildMenu(
						e,
						treeRight,
						(o, args) =>
						{
							var bindedObject = ((ConlluNode)e.Node).Sender;
							var clone = (ConlluNode)e.Node.Clone();
							clone.Sender = bindedObject;
							nounTree.Nodes.Add(clone);
						},
						(o, args) =>
						{

							var bindedObject = ((ConlluNode)e.Node).Sender;
							var clone = (ConlluNode)e.Node.Clone();
							clone.Sender = bindedObject;
							antecedentTree.Nodes.Add(clone);
						});
				}
			};
		}

		private void buildMenu(TreeNodeMouseClickEventArgs e, TreeView tree, Action<object, EventArgs> clickEventLeft, Action<object, EventArgs> clickEventRight)
		{
			var bindedObject = ((ConlluNode)e.Node).Sender;

			var token = bindedObject as Token;
			if (token == null)
			{
				return;
			}

			var left = new MenuItem("Добавить как местоименную часть");
			var right = new MenuItem("Добавить как антецедент");
			ContextMenu mnu = new ContextMenu();
			mnu.MenuItems.Add(left);
			mnu.MenuItems.Add(right);
			left.Click += new EventHandler(clickEventLeft);
			right.Click += new EventHandler(clickEventRight);

			mnu.Show(tree, e.Location);
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var nounTreeNodes = nounTree.Nodes
				.OfType<ConlluNode>()
				.Select(t => t.Sender)
				.OfType<Token>();

			var antecedentTreeNodes = antecedentTree.Nodes
				.OfType<ConlluNode>()
				.Select(t => t.Sender)
				.OfType<Token>();

			if (!nounTreeNodes.Any() || !antecedentTreeNodes.Any())
			{
				MessageBox.Show("!nounTreeNodes.Any() || !antecedentTreeNodes.Any()");
				return;
			}

			var newReference = new Reference(nounTreeNodes.ToList(), antecedentTreeNodes.ToList());

			nounTree.Nodes.Clear();
			antecedentTree.Nodes.Clear();

			treeViewMain.Nodes.Add(newReference.GetAsNode());
		}
	}
}

