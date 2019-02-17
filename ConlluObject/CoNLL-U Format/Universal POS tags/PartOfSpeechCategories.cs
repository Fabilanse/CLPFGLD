namespace ConlluObject
{
	public enum SpeechCategories
	{
		/// <summary>
		/// Інше
		/// </summary>
		[Description(Description = "Інше")]
		X,

		/// <summary>
		/// Прикметник
		/// </summary>
		[Description(Description = "Прикметник", FullName = "Adjective")]
		Adj,

		/// <summary>
		/// Положення?
		/// </summary>
		[Description(Description = "Положення", FullName = "Adposition")]
		Adp,

		/// <summary>
		/// Наріччя
		/// </summary>
		[Description(Description = "Наріччя", FullName = "Adverb")]
		Adv,

		/// <summary>
		/// Допоміжний?
		/// </summary>
		[Description(Description = "Допоміжний", FullName = "Auxiliary")]
		Aux,

		/// <summary>
		/// Кординуючий вз'язок
		/// </summary>
		[Description(Description = "Кординуючий вз'язок", FullName = "Coordinating conjunction")]
		Cconj,

		/// <summary>
		/// Визначення
		/// </summary>
		[Description(Description = "Визначення", FullName = "Determiner")]
		Det,

		/// <summary>
		/// Вигук
		/// </summary>
		[Description(Description = "Вигук", FullName = "Interjection")]
		Intj,

		/// <summary>
		/// Іменник
		/// </summary>
		[Description(Description = "Іменник", FullName = "Noun")]
		Noun,

		/// <summary>
		/// Цифра
		/// </summary>
		[Description(Description = "Цифра", FullName = "Numeral")]
		Num,

		/// <summary>
		/// Частка
		/// </summary>
		[Description(Description = "Частка", FullName = "Particle")]
		Part,

		/// <summary>
		/// Займенник
		/// </summary>
		[Description(Description = "Займенник", FullName = "Pronoun")]
		Pron,

		/// <summary>
		/// Власний іменник
		/// </summary>
		[Description(Description = "Власний іменник", FullName = "Proper noun")]
		Propn,

		/// <summary>
		/// Пунктуація
		/// </summary>
		[Description(Description = "Пунктуація", FullName = "Punctuation")]
		Punct,

		/// <summary>
		/// Підпорядкований зв'язок
		/// </summary>
		[Description(Description = "Підпорядкований зв'язок", FullName = "Subordinating conjunction")]
		Sconj,

		/// <summary>
		/// Символ
		/// </summary>
		[Description(Description = "Символ", FullName = "Symbol")]
		Sym,

		/// <summary>
		/// Дієслово
		/// </summary>
		[Description(Description = "Дієслово", FullName = "Verb")]
		Verb
	}

	public static class PartOfSpeechCategories
	{
		public static SpeechCategories Get(string value)
		{
			return BaseTools.StringToEnum<SpeechCategories>(value);
		}
	}
}
