using System;
using System.Collections.Generic;

namespace ConlluObject.Tokenization
{
	[Serializable]
	public class Paragraph
	{
		public string Name { get; set; }

		public List<Sentence> Sentences { get;set;}

		public Paragraph()
		{
			Sentences = new List<Sentence>();
		}

		/// <summary>
		/// В связях токенов указать ссылки на токены с которыми у них связь
		/// </summary>
		public void RefreshRelations()
		{
			foreach (var sentence in Sentences)
			{
				sentence.RefreshRelations();
			}
		}
	}
}
