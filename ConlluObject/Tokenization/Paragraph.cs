using System.Collections.Generic;

namespace ConlluObject.Tokenization
{
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
