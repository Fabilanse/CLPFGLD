
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
	}
}
