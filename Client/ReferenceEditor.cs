using ConlluObject.Tokenization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public class Reference
	{
		/// <summary>
		/// Местоименная часть
		/// </summary>
		public IEnumerable<Token> Noun { get; private set; }

		/// <summary>
		/// Антецедентная часть
		/// </summary>
		public IEnumerable<Token> Аntecedent { get; private set; }

		/// <summary>
		/// Конструктор
		/// </summary>
		public Reference(IEnumerable<Token> noun, IEnumerable<Token> antecedent)
		{
			Noun = noun;
			Аntecedent = antecedent;
		}

		/// <summary>
		/// Получить как ветку дерева
		/// </summary>
		/// <returns></returns>
		public TreeNode GetAsNode()
		{
			var nounStr = string.Join("-", Noun.Select(t => t.ToString()));

			var antecedent = string.Join("-", Аntecedent.Select(t => t.ToString()));

			return new TreeNode(string.Format("{0} -> {1}", nounStr, antecedent));
		}
	}

	internal class ReferenceEditor
	{
		/// <summary>
		/// Анафорические связи
		/// </summary>
		public List<Reference> References { get; set; }
	}
}
