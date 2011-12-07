using System;
using System.ServiceProcess;

namespace JustDeploy.WindowsServices
{
	public static class ServiceBaseExtensions
	{
		public static void SetProperties(this ServiceBase service, IHostedWindowsService hostedWindowsService)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			if (hostedWindowsService == null)
				throw new ArgumentNullException("hostedWindowsService");

			service.ServiceName = hostedWindowsService.ServiceName;
			service.CanPauseAndContinue = hostedWindowsService.CanPauseAndContinue;
			service.CanShutdown = hostedWindowsService.CanShutdown;
			service.CanStop = hostedWindowsService.CanStop;			
		}
	}
}