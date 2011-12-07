using System;
using System.Collections.Generic;
using System.Reflection;
using JustDeploy.Reflection;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace JustDeploy
{

	public class JustDeployRegistry : Registry
	{
		public JustDeployRegistry()
		{

			{

				Scan(x =>

				     	{
				     		// Scan the types in the assembly that contains this Registry class
				     		x.TheCallingAssembly();

				     		// Specify some scanning conventions
				     		x.AddAllTypesOf<IDomainMap>();
				     		x.WithDefaultConventions();
				     	});
			}
		}

	//public class DependencyDefinition<TInterface, TImplementation> : IDependencyDefinition where TImplementation : class, TInterface, new()
	//{
	//  public string Name { get; set; }
	//}

	//public interface IDependencyDefinition
	//{
	//  string Name { get; set; }
	//}

	//public class DependencyRegistrar
	//{
	//  public void RegisterDependency(Assembly assembly)
	//  {
	//    var defs = AssemblyUtils.GetAll<IDependencyDefinition>(assembly);

	//    foreach(var def in defs)
	//    {
	//      RegisterDependency(def);
	//    }
	//  }

	//  public void RegisterDependency(IDependencyDefinition definition)
	//  {
	//    ObjectFactory
	//  }
	//}

	//public class Dependency
	//{
	//  public TInterface GetInstance<TInterface>(string name = null)
	//  {
	//    return String.IsNullOrEmpty(name) 
	//      ? ObjectFactory.GetInstance<TInterface>() 
	//      : ObjectFactory.GetNamedInstance<TInterface>(name);
	//  }

	//  public IList<TInterface> GetAllInstances<TInterface>()
	//  {
	//    return ObjectFactory.GetAllInstances<TInterface>();
	//  }
	//}
}
