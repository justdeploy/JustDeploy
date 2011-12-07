using JustDeploy.WindowsServices;

namespace JustDeploy.DeploymentController
{
	class Program
	{
		static void Main(string[] args)
		{
			Application.Init();

			var wrapper = new WindowsServiceProgram<DeploymentController>();
			wrapper.Run(args);
		}
	}
}
