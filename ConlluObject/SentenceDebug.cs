using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConlluObjectTokenSentenceDebug
{
	[Serializable]
	public class TokenSentenceDebug
	{
		private List<string> _tokenKeys = new List<string>
		{
			"id",
			"form",
			"lemma",
			"upostag",
			"xpostag",
			"feats",
			"head",
			"deprel",
			"deps",
			"misc"
		};

		/*
 [('id', 1), 
('form', u'\u0414\u0456\u0434\u0443\u0441\u044c'), 
('lemma', u'\u0434\u0456\u0434\u0443\u0441\u044c'), 
('upostag', 'NOUN'), 
('xpostag', 'Ncmsny'), 
('feats', OrderedDict([
    ('Animacy', 'Anim'), 
    ('Case', 'Nom'),
    ('Gender', 'Masc'), 
    ('Number', 'Sing')])),
('head', 7), 
('deprel', 'nsubj'), 
('deps', [('nsubj', 7), ('nsubj', 9)]), 
('misc', OrderedDict([
    ('Id', '02tp'), 
    ('LTranslit', u'didu\u015b'), 
    ('SpaceAfter', 'No'), 
    ('Translit', u'Didu\u015b')]))])

 */

		public dynamic Id { get; set; }

		public string Form { get; set; }

		public string Lemma { get; set; }

		public string Upostag { get; set; }

		public string Xpostag { get; set; }

		public FeatsDebug Feats { get; set; }

		public int Head { get; set; }

		public string Deprel { get; set; }

		public dynamic Deps { get; set; }

		public MiscDebug Misc { get; set; }

		public TokenSentenceDebug(dynamic obj)
		{
			Id = obj["id"];
			Form = obj["form"];
			Lemma = Tools.GetValue<string>(obj, "lemma");
			Upostag = obj["upostag"];
			Xpostag = obj["xpostag"];
			Feats = new FeatsDebug(obj["feats"]);
			Head = Tools.GetValue<int>(obj, "head");
			Deprel = obj["deprel"];
			Deps = obj["deps"];
			Misc = new MiscDebug(obj["misc"]);
		}
	}

	[Serializable]
	public class MiscDebug
	{
		public string Id { get; set; }

		public string LTranslit { get; set; }

		public bool SpaceAfter { get; set; }

		public string Translit { get; set; }

		public MiscDebug(dynamic obj)
		{
			Id = Tools.GetValue<string>(obj, "Id");
			LTranslit = Tools.GetValue<string>(obj, "LTranslit");
			var spaceAfter = Tools.GetValue<string>(obj, "SpaceAfter");
			SpaceAfter = spaceAfter != "No" && spaceAfter != string.Empty;
			Translit = Tools.GetValue<string>(obj, "Translit");
		}
	}

	[Serializable]
	public class FeatsDebug
	{
		public string Animacy { get; set; }

		public string Case { get; set; }

		public string Gender { get; set; }

		public string Number { get; set; }

		public FeatsDebug(dynamic obj)
		{
			Animacy = Tools.GetValue<string>(obj, "Animacy");
			Case = Tools.GetValue<string>(obj, "Case");
			Gender = Tools.GetValue<string>(obj, "Gender");
			Number = Tools.GetValue<string>(obj, "Number");
		}
	}

	public static class Tools
	{
		public static T GetValue<T>(dynamic obj, string key)
		{
			if (obj == null || !obj.has_key(key) || obj[key] == null)
			{
				return default(T);
			}

			return obj[key];
		}
	}
}
