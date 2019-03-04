using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConlluObject.Tokenization
{
	[Serializable]
	public class Sentence
	{
		public List<Token> Tokens { get; set; }

		public Sentence()
		{
			Tokens = new List<Token>();
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (var token in Tokens)
			{
				sb.AppendFormat("{0}{1}", token.Form, token.Misc.SpaceAfter ? " " : string.Empty);
			}
			return sb.ToString();
		}

		/// <summary>
		/// В связях токенов указать ссылки на токены с которыми у них связь
		/// </summary>
		public void RefreshRelations()
		{
			foreach (var token in Tokens)
			{
				foreach (var relation in token.Deps.Relations)
				{
					var targetId = relation.RelationId;
					var targetItem = Tokens.Where(t=>t.Id is int).FirstOrDefault(t => t.Id == targetId);
					if (targetItem != null)
					{
						relation.RelatedToken = targetItem;
					}
				}
			}
		}
	}
}
