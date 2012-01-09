using JustDeploy.DI;

namespace JustDeploy.IO
{

	/// <summary>
	/// A JSON serialization utility
	/// </summary>
	public static class Json
	{
		private static IJsonSerializer JsonSerializer { get { return InstanceFactory.Get<IJsonSerializer>(); } }

		/// <summary>
		/// Convert the given object to its Json representation
		/// </summary>
		/// <param name="value">The value to serialize.</param>
		/// <returns></returns>
		public static string To(object value)
		{
			return JsonSerializer.ToJson(value);
		}

		/// <summary>
		/// Convert the given string back into an object
		/// </summary>
		/// <typeparam name="T">The type of the object</typeparam>
		/// <param name="value">The json string</param>
		/// <returns></returns>
		public static T From<T>(string value)
		{
			return JsonSerializer.From<T>(value);
		}
	}
}
