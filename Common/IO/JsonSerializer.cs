using Newtonsoft.Json;

namespace JustDeploy.IO
{
	/// <summary>
	/// A Json Serializer
	/// </summary>
	public class JsonSerializer : IJsonSerializer
	{
		/// <summary>
		/// Convert the given object to its Json representation
		/// </summary>
		/// <param name="value">The value to serialize.</param>
		/// <returns></returns>
		public string ToJson(object value)
		{
			return JsonConvert.SerializeObject(value);
		}

		/// <summary>
		/// Convert the given string back into an object
		/// </summary>
		/// <typeparam name="T">The type of the object</typeparam>
		/// <param name="value">The json string</param>
		/// <returns></returns>
		public T From<T>(string value)
		{
			return JsonConvert.DeserializeObject<T>(value);
		}
	}
}