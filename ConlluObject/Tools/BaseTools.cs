using System;
using System.Linq;
using System.Reflection;

namespace ConlluObject
{
	public static class BaseTools
	{
		public static T GetValue<T>(dynamic obj, string key)
		{
			if (obj == null || !obj.has_key(key) || obj[key] == null)
			{
				return default(T);
			}

			return obj[key];
		}

		public static T StringToEnum<T>(string value) where T : struct, IConvertible
		{
			if (string.IsNullOrEmpty(value) || value == "_")
			{
				return default(T);
			}
			
			// Первый символ верхний регистр, остальные нижний так как строка должна полностью совпадать со значением enum
			var editedValue = value.First().ToString().ToUpper() + value.Substring(1).ToLower();

			return (T)Enum.Parse(typeof(T), editedValue);
		}

		public static Expected GetAttributeValue<T, Expected>(this Enum enumeration, Func<T, Expected> expression) where T : Attribute
		{
			T attribute =
			  enumeration
				.GetType()
				.GetMember(enumeration.ToString())
				.Where(member => member.MemberType == MemberTypes.Field)
				.FirstOrDefault()
				.GetCustomAttributes(typeof(T), false)
				.Cast<T>()
				.SingleOrDefault();

			if (attribute == null)
				return default(Expected);

			return expression(attribute);
		}
	}
}
