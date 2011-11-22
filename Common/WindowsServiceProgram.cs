using System;
using System.Linq;
using System.ServiceProcess;
using System.Threading;

namespace JustDeploy.Common
{
	public class WindowsServiceProgram<T> where T : ServiceBase, new()
	{
		private Thread _programThread;

		public void Run(string[] args)
		{
			var 

			if(args.Contains("-console"))
			{
				RunFromCommandLine();
			}
			else
			{
				var servicesToRun = new ServiceBase[] 
			                              	{ 
			                              		new T() 
			                              	};
				ServiceBase.Run(servicesToRun);
			}			
		}

		private void RunFromCommandLine()
		{
			_programThread = new Thread(() => dgfd);
			_programThread.Start();
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

			if (!_programThread.IsAlive)
				return;

			// try harder
			_programThread.Abort();
			_programThread.Join(TimeSpan.FromMinutes(1));
		}
	}

}
