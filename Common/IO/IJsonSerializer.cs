namespace JustDeploy.IO
{
	/// <summary>
	/// A contract for Json object serialization
	/// </summary>
	public interface IJsonSerializer
	{
		/// <summary>
		/// Convert the given object to its Json representation
		/// </summary>
		/// <param name="value">The value to serialize.</param>
		/// <returns></returns>
		string ToJson(object value);

		/// <summary>
		/// Convert the given string back into an object
		/// </summary>
		/// <typeparam name="T">The type of the object</typeparam>
		/// <param name="value">The json string</param>
		/// <returns></returns>
		T From<T>(string value);
	}
}