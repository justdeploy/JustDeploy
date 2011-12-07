using JustDeploy.WindowsServices;

namespace JustDeploy.DeploymentAgent
{
	static class Program
	{
		static void Main(string[] args)
		{
			Application.Init();

			var wrapper = new WindowsServiceProgram<DeploymentAgent>();
			wrapper.Run(args);
		}
	}
}
