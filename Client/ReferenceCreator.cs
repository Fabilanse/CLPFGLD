using ConlluObject.Tokenization;
using ConlluObject.Tools.TreeBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trestan;

namespace Client
{
	public partial class ReferenceCreator : Form
	{
		clsResize _form_resize;

		public ReferenceCreator(List<Sentence> sentences)
		{
			InitializeComponent();

			//_form_resize = new clsResize(this);
			//this.Load += _Load;
			//this.Resize += _Resize;

			var conlluTreeBuilder = new ConlluTreeBuilder(sentences);

			//var conlluTree = conlluTreeBuilder.BuildTree();

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

		private void _Load(object sender, EventArgs e)
		{
			_form_resize._get_initial_size();
		}

		private void _Resize(object sender, EventArgs e)
		{
			_form_resize._resize();
		}
	}
}
