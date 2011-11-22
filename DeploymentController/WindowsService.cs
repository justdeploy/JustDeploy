using System.ServiceProcess;

namespace JustDeploy.DeploymentController
{
	public class WindowsService : ServiceBase
	{
		/// <summary>
		/// Public Constructor for WindowsService.
		/// - Put all of your Initialization code here.
		/// </summary>
		public WindowsService()
		{
			ServiceName = "JustDeploy Controller";

			CanShutdown = true;
			CanStop = true;
		}

		protected override void OnStart(string[] args)
		{
		}

		protected override void OnStop()
		{
		}
	}
}