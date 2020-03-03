using System.Collections.Generic;
using System.Windows.Forms;

namespace ConlluObject.Tools.TreeBuilder
{
	public class ConlluNode: TreeNode
	{
		///// <summary>
		///// Текст вершины
		///// </summary>
		//public string Text { get; private set; }

		/// <summary>
		/// Дочерние элементы
		/// </summary>
		public List<ConlluNode> Childs { get; private set; }

		/// <summary>
		/// Привязанный объект
		/// </summary>
		public object Sender { get; set; }

		public ConlluNode()
		{

		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="text">Текст</param>
		public ConlluNode(object sender, string text)
		{
			Sender = sender;
			Text = text;
			Childs = new List<ConlluNode>();
		}
	}
}
