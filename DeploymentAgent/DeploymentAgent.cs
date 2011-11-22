using System.ServiceModel;
using JustDeploy.Common.WindowsServices;

namespace JustDeploy.DeploymentAgent
{
	public class DeploymentAgent : HostedWindowsServiceBase
	{
		private ServiceHost serviceHost;

		public override string ServiceName
		{
			get { return "JustDeploy Agent"; }
		}

		public override bool CanStop
		{
			get { return true; }
		}
		
		public override void Start()
		{
			serviceHost = new ServiceHost(typeof(MyCoolService));
			serviceHost.Open();			
		}

		public override void Stop()
		{
			serviceHost.Close();
		}
	}
}
