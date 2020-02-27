using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

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
		public bool InitFromBinFile(string filePath, Progress<int> progress = null)
		{
			using (var stream = File.OpenRead(filePath))
			{
				var paragraph = Deserialize<Paragraph>(stream, progress);
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

		public static T Deserialize<T>(Stream stream, IProgress<int> progress)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}

			if (!stream.CanSeek)
			{
				throw new ArgumentException("stream");
			}

			Timer timer = null;
			if (progress != null)
			{
				timer = new Timer(delegate
				{
					progress.Report((int)(stream.Position * 100.0 / stream.Length));
				},
				null, 0, 500);
			}

			BinaryFormatter formatter = new BinaryFormatter();
			T graph = (T)formatter.Deserialize(stream);

			if (timer != null)
			{
				timer.Dispose();
			}

			return graph;
		}
	}
}
