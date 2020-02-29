using ConlluObject.Tokenization;
using System.Collections.Generic;
using System.Windows.Forms;
using ConlluObject.Tools.TreeBuilder;
using System;

namespace Client
{
	public partial class TreeViewForm : Form
	{
		/// <summary>
		/// Событие по нажатию правой кнопки мышы
		/// </summary>
		public Action RightClickAction { get; set; }

		public TreeViewForm(List<Sentence> sentences)
		{
			InitializeComponent();

			var conlluTreeBuilder = new ConlluTreeBuilder(sentences);

			var conlluTree = conlluTreeBuilder.BuildTree();

			conlluTreeBuilder.PassConlluTree(tree.Nodes, conlluTree);
		}
	}
}
