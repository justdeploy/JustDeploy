using Common.Logging;
using JustDeploy.WindowsServices;

namespace JustDeploy.DeploymentAgent
{
	static class Program
	{
		static void Main(string[] args)
		{
			Application.Init();

			LogManager.GetCurrentClassLogger().Warn("Hello world! from Logger");

			var wrapper = new WindowsServiceProgram<DeploymentAgent>();
			wrapper.Run(args);
		}
	}
}
