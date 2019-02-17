using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConlluObject
{
	public enum DependencyRelationsTypes
	{
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "Null")]
		Null,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "Clausal modifier of noun (adjectival clause)")]
		Acl,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "adverbial clause modifier")]
		Advcl,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "adverbial modifier")]

		Advmod,
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "appositional modifier")]
		Appos,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "adjectival modifier")]
		Amod,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "auxiliary")]
		Aux,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = " case marking")]
		Case,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "coordinating conjunction")]
		Cc,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "clausal complement")]
		Ccomp,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "classifier")]
		Clf,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "compound")]
		Compound,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "conjunct")]
		Conj,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "copula")]
		Cop,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "clausal subject")]
		Csubj,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "unspecified dependency")]
		Dep,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "determiner")]
		Det,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "discourse element")]
		Discourse,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "dislocated elements")]
		Dislocated, 
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "expletive")]
		Expl,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "fixed multiword expression")]
		Fixed,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "flat multiword expression")]
		Flat,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "goes with")]
		Goeswith,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "indirect object")]
		Iobj,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "list")]
		List,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "marker")]
		Mark,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "nominal modifier")]
		Nmod,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "nominal subject")]
		Nsubj,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "numeric modifier")]
		Nummod,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "object")]
		Obj,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "oblique nominal")]
		Obl,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "orphan")]
		Orphan,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "parataxis")]
		Parataxis,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "punctuation")]
		Punct,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "overridden disfluency")]
		Reparandum,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "root")]
		Root,
		
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "vocative")]
		Vocative,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = " open clausal complement")]
		Xcomp
	}

	public static class DependencyRelationsTools
	{
		public static DependencyRelationsTypes Get(string value)
		{
			if (string.IsNullOrEmpty(value) || value == "_")
			{
				return DependencyRelationsTypes.Null;
			}
			var splitedValue = value.Split(':')[0];
			var firstToUpper = splitedValue.First().ToString().ToUpper() + splitedValue.Substring(1);
			return (DependencyRelationsTypes)Enum.Parse(typeof(DependencyRelationsTypes), firstToUpper);
		}
	}
}
