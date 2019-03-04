using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConlluObject.Tokenization
{
	[Serializable]
	public class Paragraph
	{
		public string Name { get; set; }

		public List<Sentence> Sentences { get;set;}
		public object Properties { get; private set; }

		public Paragraph()
		{
			Sentences = new List<Sentence>();
		}

		/// <summary>
		/// Инициализировать из сериализированого файла
		/// </summary>
		/// <param name="filePath">Путь к файлу</param>
		/// <returns>Признак успешной инициализации</returns>
		public bool InitFromBinFile(string filePath)
		{
			using (var stream = File.OpenRead(filePath))
			{
				var formatter = new BinaryFormatter();
				var paragraph = (Paragraph)formatter.Deserialize(stream);
				if (paragraph != null)
				{
					paragraph.RefreshRelations();
					Sentences = paragraph.Sentences;
					return true;
				}
			}
			return false;
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
