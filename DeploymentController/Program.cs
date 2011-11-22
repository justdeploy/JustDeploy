using JustDeploy.Common.WindowsServices;

namespace JustDeploy.DeploymentController
{
	class Program
	{
		static void Main(string[] args)
		{
			var wrapper = new WindowsServiceProgram<DeploymentController>();
			wrapper.Run(args);
		}
	}
}
