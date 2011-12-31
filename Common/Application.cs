using JustDeploy.DI;

namespace JustDeploy
{
	public static class Application
	{
		public const string WcfNamespace = "http://schemas.nexia.ca/justdeploy/2011/12/";

		public static void Init()
		{
			DiContainer.Init();
		}
	}
}
