namespace JustDeploy.WindowsServices
{
	public abstract class HostedWindowsServiceBase : IHostedWindowsService
	{
		public abstract string ServiceName { get; }

		public virtual bool CanShutdown
		{
			get { return false; }
		}

		public virtual bool CanStop
		{
			get { return false; }
		}

		public virtual bool CanPauseAndContinue
		{
			get { return false; }
		}

		public abstract void Start();

		public virtual void Stop()
		{
		}

		public virtual void Pause()
		{
		}

		public virtual void Continue()
		{
		}

		public virtual void OnShutdown()
		{
		}
	}
}
