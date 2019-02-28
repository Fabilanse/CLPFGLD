using System;
using System.Collections.Generic;
using ConlluObject.Tokenization;

namespace ConlluObject
{
	[Serializable]
	public class Sentence
	{
		public List<Token> Tokens { get; set; }

		public Sentence()
		{
			Tokens = new List<Token>();
		}
	}
}
