using System;

namespace ConlluObject
{
	public class DescriptionAttribute : Attribute
	{
		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Полное имя
		/// </summary>
		public string FullName { get;set;}
	}
}
