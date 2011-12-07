using System;
using DeploymentControllerLib;
using JustDeploy.WindowsServices;

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
			var blah = new Class1();

			blah.DoStuff();
		}
	}
}
