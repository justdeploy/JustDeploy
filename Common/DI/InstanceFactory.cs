using System.Collections.Generic;
using StructureMap;

namespace JustDeploy.DI
{
	public static class InstanceFactory
	{
		public static T Get<T>()
		{
			return ObjectFactory.GetInstance<T>();
		}

		public static IEnumerable<T> GetAll<T>()
		{
			return ObjectFactory.GetAllInstances<T>();
		}
	}
}
