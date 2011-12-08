using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace JustDeploy.DI
{
	public abstract class RegistryBase<T> : Registry where T : Registry
	{
		protected RegistryBase()
		{
			Scan(x =>
			{
				x.AssemblyContainingType<T>();
				x.WithDefaultConventions();

				ScanInternal(x);
			});
		}

		protected virtual void ScanInternal(IAssemblyScanner assemblyScanner)
		{
			/* Do nothing */
		}
	}
}
