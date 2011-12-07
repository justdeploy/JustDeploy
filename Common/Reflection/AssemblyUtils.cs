using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace JustDeploy.Reflection
{
	public class AssemblyUtils
	{
		public static IEnumerable<Type> GetAll<TInterface>(Assembly assembly)
		{
			var type = typeof(TInterface);
			return assembly.GetTypes().Where(type.IsAssignableFrom);
		}
	}
}