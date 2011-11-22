using JustDeploy.Common.WindowsServices;

namespace JustDeploy.DeploymentAgent
{
	static class Program
	{
		static void Main(string[] args)
		{
			var wrapper = new WindowsServiceProgram<DeploymentAgent>();
			wrapper.Run(args);
		}
	}
}
