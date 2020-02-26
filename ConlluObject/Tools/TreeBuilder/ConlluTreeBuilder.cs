using System.Collections.Generic;
using ConlluObject.Tokenization;

namespace ConlluObject.Tools.TreeBuilder
{
	/// <summary>
	/// Построитель иерархии
	/// </summary>
	public class ConlluTreeBuilder
	{
		/// <summary>
		/// Предложение
		/// </summary>
		public List<Sentence> Sentences { get; private set; }

		/// <summary>
		/// Кнструктор
		/// </summary>
		public ConlluTreeBuilder(List<Sentence> sentences)
		{
			Sentences = sentences;
		}

		/// <summary>
		/// Построить дерево
		/// </summary>
		public List<ConlluNode> BuildTree()
		{
			var tree = new List<ConlluNode>();
			foreach (var sentence in Sentences)
			{
				var sentenceNode = new ConlluNode(sentence.ToString());
				tree.Add(sentenceNode);

				foreach (var token in sentence.Tokens)
				{
					var tokenNode = new ConlluNode(token.ToString());
					sentenceNode.Childs.Add(tokenNode);

					var tokenType = token.GetType();

					foreach (var prop in tokenType.GetProperties())
					{
						var propValue = prop.GetValue(token);

						var atributesValues = getAtributesValues(propValue);

						var propNodeText = string.Format("{0}: {1}. {2}",
							prop.Name,
							propValue,
							string.IsNullOrEmpty(atributesValues)
								? string.Empty
								: string.Format(@"Детально -> {0}", atributesValues));

						var propNode = new ConlluNode(propNodeText);
						tokenNode.Childs.Add(propNode);

						if (propValue is Misc)
						{
							var miscType = propValue.GetType();

							foreach (var miscProp in miscType.GetProperties())
							{
								var miscNode = new ConlluNode(string.Format("{0}: {1}", miscProp.Name, miscProp.GetValue(propValue)));
								propNode.Childs.Add(miscNode);
							}
						}
					}
				}
			}
			return tree;
		}

		private string getAtributesValues(object propValue)
		{
			if (propValue is SpeechCategories)
			{
				var description = ((SpeechCategories)propValue).GetAttributeValue<DescriptionAttribute, string>(t => t.Description);
				var fullName = ((SpeechCategories)propValue).GetAttributeValue<DescriptionAttribute, string>(t => t.FullName);

				return string.Format("Повна назва: {0}, Детально: {1}", fullName, description);
			}

			return string.Empty;
		}
	}
}
