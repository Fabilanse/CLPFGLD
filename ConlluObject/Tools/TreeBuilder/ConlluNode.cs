using System.Collections.Generic;

namespace ConlluObject.Tools.TreeBuilder
{
	public class ConlluNode
	{
		/// <summary>
		/// Текст вершины
		/// </summary>
		public string Text { get; private set; }

		/// <summary>
		/// Дочерние элементы
		/// </summary>
		public List<ConlluNode> Childs { get; private set; }

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="text">Текст</param>
		public ConlluNode(string text)
		{
			Text = text;
			Childs = new List<ConlluNode>();
		}
	}

}
