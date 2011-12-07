using StructureMap.Configuration.DSL;

namespace JustDeploy.DI
{
	public class DiRegistry : Registry
	{
		public DiRegistry()
		{
			Scan(x =>
			     	{
			     		x.AssembliesFromApplicationBaseDirectory();
			     		x.WithDefaultConventions();
			     	});
		}
	}
}
