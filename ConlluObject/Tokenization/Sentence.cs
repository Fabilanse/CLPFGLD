using System;
using System.Collections.Generic;
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
	}
}
