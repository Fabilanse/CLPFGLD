using ConlluObject.Tokenization;
using ConlluObject.Tools.TreeBuilder;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
					left.Click += new EventHandler((o, args) =>
					{
						treeViewLeft.Nodes.Add((TreeNode)e.Node.Clone());
					});

					mnu.Show(treeLeft, e.Location);
				}
			};
		}
	}
}
