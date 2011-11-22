using System;
using System.ServiceProcess;

namespace JustDeploy.Common.WindowsServices
{
	public class WindowsServiceHost : ServiceBase
	{
		public void Init(IHostedWindowsService hostedService)
		{
			if (hostedService == null)
				throw new ArgumentNullException("hostedService");

			this.SetProperties(hostedService);
			HostedService = hostedService;
		}

		private IHostedWindowsService HostedService { get; set; }

		protected override void OnStart(string[] args)
		{
			HostedService.Start();
		}

		protected override void OnStop()
		{
			HostedService.Stop();
		}

		protected override void OnPause()
		{
			HostedService.Pause();
		}

		protected override void OnContinue()
		{
			HostedService.Continue();
		}

		protected override void OnShutdown()
		{
			HostedService.OnShutdown();
		}
	}
}