using StructureMap;

namespace JustDeploy.DI
{
	public static class DiContainer
	{
		public static void Init()
		{
			ObjectFactory.Initialize(x => x.AddRegistry<DiRegistry>());
		}
	}
}
