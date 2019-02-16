using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConlluObject.Universal_Features
{
	public enum AnimacyTypes
	{
		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "Animate")]
		Anim,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "Human")]
		Hum,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "Inanimate")]
		Inan,

		/// <summary>
		/// 
		/// </summary>
		[Description(Description = "", FullName = "Non-humam")]
		Nhum
	}

	public static class AnimacyTools
	{
		public static AnimacyTypes Get(string txt)
		{
			switch (txt)
			{
				case "Anim":
					return AnimacyTypes.Anim;
				case "Hum":
					return AnimacyTypes.Hum;
				case "Inan":
					return AnimacyTypes.Inan;
				case "Nhum":
					return AnimacyTypes.Nhum;
				default:
					throw new NotImplementedException();
			}
		}
	}
}
