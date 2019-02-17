using System;

namespace ConlluObject
{
	public enum AnimacyTypes
	{
		/// <summary>
		/// Null
		/// </summary>
		[Description(Description = "", FullName = "Null")]
		Null,

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
			if (string.IsNullOrEmpty(txt))
			{
				return AnimacyTypes.Null;
			}

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
