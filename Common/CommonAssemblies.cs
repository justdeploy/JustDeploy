using System.Collections.Generic;
using System.Reflection;

namespace JustDeploy
{
	public class CommonAssemblies
	{
		private static readonly Assembly CommonAssembly = Assembly.GetAssembly(typeof (CommonAssemblies));

		public IEnumerable<Assembly> Get()
		{
			return new[] { CommonAssembly };
		}
	}
}