using System;
using System.Linq;
using System.ServiceProcess;
using System.Threading;

namespace JustDeploy.Common.WindowsServices
{
	public class WindowsServiceProgram<T> where T : IHostedWindowsService, new()
	{
		public void Run(string[] args)
		{
			var _hostedService = new T();

			if(args.Contains("-console"))
			{
				RunFromCommandLine(_hostedService);
			}
			else
			{
				var service = new WindowsServiceHost();
				service.Init(_hostedService);
				var servicesToRun = new ServiceBase[] 
			                              	{ 
			                              		service 
			                              	};
				ServiceBase.Run(servicesToRun);
			}			
		}

		private void RunFromCommandLine(T hostedService)
		{
			var programThread = new Thread(hostedService.Start);
			programThread.Start();
			Console.WriteLine("Press esc to quit.");

			while (true)
			{
				if (Console.KeyAvailable)
				{
					var key = Console.ReadKey(true);
					if (key.Key == ConsoleKey.Escape)
					{
						Console.WriteLine("Please wait while the service shuts down. (this may take a couple minutes)");
						Thread.Sleep(TimeSpan.FromSeconds(5));
						break;
					}
				}
				else
				{
					Thread.Sleep(TimeSpan.FromMilliseconds(500));
				}
			}

			if (!programThread.IsAlive)
				return;

			// try harder
			programThread.Abort();
			programThread.Join(TimeSpan.FromMinutes(1));
		}
	}

}
