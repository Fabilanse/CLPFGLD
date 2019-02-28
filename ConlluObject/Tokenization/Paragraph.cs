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
	}
}
