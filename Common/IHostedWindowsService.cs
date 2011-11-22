namespace JustDeploy.Common
{
	public interface IHostedWindowsService
	{
		string ServiceName { get; }

		bool CanShutdown { get; }
		bool CanStop { get; }
		bool CanPauseAndContinue { get; }

		void Start();
		void Stop();
		void Pause();
		void Continue();
		void OnShutdown();
	}
}