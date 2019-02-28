using System;

namespace ConlluObject.Tokenization
{
	[Serializable]
	public class Token
	{
		public dynamic Id { get; set; }

		public string Form { get; set; }

		public string Lemma { get; set; }

		public SpeechCategories Upostag { get; set; }

		public string Xpostag { get; set; }

		public Feats Feats { get; set; }

		public int Head { get; set; }

		/// <summary>
		/// Универсальное отношение зависимости к HEAD (root iff HEAD = 0) или определенный подтип для конкретного языка.
		/// </summary>
		public DependencyRelationsTypes Deprel { get; set; }

		public dynamic Deps { get; set; }

		public Misc Misc { get; set; }

		public Token(dynamic obj)
		{
			Id = obj["id"];
			Form = obj["form"];
			Lemma = BaseTools.GetValue<string>(obj, "lemma");
			Upostag = PartOfSpeechCategories.Get(BaseTools.GetValue<string>(obj, "upostag"));
			Xpostag = obj["xpostag"];
			Feats = new Feats(obj["feats"]);
			Head = BaseTools.GetValue<int>(obj, "head");
			Deprel = DependencyRelationsTools.Get(BaseTools.GetValue<string>(obj, "deprel"));
			Deps = new Deps(obj["deps"]);
			Misc = new Misc(obj["misc"]);
		}

		public override string ToString()
		{
			return Form;
		}
	}

	[Serializable]
	public class Misc
	{
		public string Id { get; set; }

		public string LTranslit { get; set; }

		public bool SpaceAfter { get; set; }

		public string Translit { get; set; }

		public Misc(dynamic obj)
		{
			Id = BaseTools.GetValue<string>(obj, "Id");
			LTranslit = BaseTools.GetValue<string>(obj, "LTranslit");
			var spaceAfter = BaseTools.GetValue<string>(obj, "SpaceAfter");
			SpaceAfter = spaceAfter != "No" && spaceAfter != string.Empty;
			Translit = BaseTools.GetValue<string>(obj, "Translit");
		}
	}

	[Serializable]
	public class Feats
	{
		public AnimacyTypes Animacy { get; set; }

		public string Case { get; set; }

		public string Gender { get; set; }

		public string Number { get; set; }

		public Feats(dynamic obj)
		{
			Animacy = AnimacyTools.Get(BaseTools.GetValue<string>(obj, "Animacy"));
			Case = BaseTools.GetValue<string>(obj, "Case");
			Gender = BaseTools.GetValue<string>(obj, "Gender");
			Number = BaseTools.GetValue<string>(obj, "Number");
		}
	}

	[Serializable]
	public class Deps
	{
		public dynamic Value { get; set; }

		public Deps(dynamic obj)
		{
			Value = obj;
		}
	}
}
