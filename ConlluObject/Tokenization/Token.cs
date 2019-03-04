using System;
using System.Collections.Generic;

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

		public Deps Deps { get; set; }

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
		public List<DependencyRelation> Relations = new List<DependencyRelation>();

		internal Deps()
		{
			Relations = new List<DependencyRelation>();
		}

		public Deps(dynamic obj): base()
		{
			for (var i = 0; i < obj.__len__(); i++)
			{
				var relType = DependencyRelationsTools.Get(obj[i][0]);
				var relId = obj[i][1];
				Relations.Add(new DependencyRelation(relType, relId));
			}
		}

		[Serializable]
		public class DependencyRelation
		{
			public DependencyRelationsTypes RelationType { get; internal set; }

			public int RelationId { get; internal set; }

			public Token RelatedToken { get; internal set; }

			public DependencyRelation(DependencyRelationsTypes dependencyRelationsType, int id)
			{
				RelationType = dependencyRelationsType;
				RelationId = id;
			}
		}
	}
}
