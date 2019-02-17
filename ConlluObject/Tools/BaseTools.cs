using System;
using System.Linq;

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
			if (string.IsNullOrEmpty(value))
			{
				return default(T);
			}
			
			// Первый символ верхний регистр, остальные нижний так как строка должна полностью совпадать со значением enum
			var editedValue = value.First().ToString().ToUpper() + value.Substring(1).ToLower();

			return (T)Enum.Parse(typeof(T), editedValue);
		}
	}
}
