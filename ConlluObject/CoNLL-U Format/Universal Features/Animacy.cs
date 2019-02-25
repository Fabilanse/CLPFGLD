namespace ConlluObject
{
	public enum AnimacyTypes
	{
		/// <summary>
		/// Null
		/// </summary>
		[Description(Description = "Не визначено", FullName = "Null")]
		Null,

		/// <summary>
		/// Істота
		/// </summary>
		[Description(Description = "Істота", FullName = "Animate")]
		Anim,

		/// <summary>
		/// Людина
		/// </summary>
		[Description(Description = "Людина", FullName = "Human")]
		Hum,

		/// <summary>
		/// Неістота
		/// </summary>
		[Description(Description = "Неістота", FullName = "Inanimate")]
		Inan,

		/// <summary>
		/// Чи істота чи ні (бактерія)
		/// </summary>
		[Description(Description = "Чи істота чи ні (бактерія)", FullName = "Non-humam")]
		Nhum
	}

	public static class AnimacyTools
	{
		public static AnimacyTypes Get(string value)
		{
			return BaseTools.StringToEnum<AnimacyTypes>(value);
		}
	}
}
