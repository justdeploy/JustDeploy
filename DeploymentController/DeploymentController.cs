using System;
using JustDeploy.Common.WindowsServices;

namespace JustDeploy.DeploymentController
{
	public class DeploymentController : HostedWindowsServiceBase
	{
		public override string ServiceName
		{
			get { return "JustDeploy Controller"; }
		}

		public override void Start()
		{
			
		}
	}
}
