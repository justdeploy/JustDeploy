using System;
using Common.Logging;
using JustDeploy.DI;
using JustDeploy.IO.WcfFileTrans;

namespace JustDeploy.DeploymentAgentLib
{
	public class AgentService : IAgentService, IFileService
	{
		public AgentService()
		{
			FileService = InstanceFactory.Get<IFileService>();
		}

		public IFileService FileService { get; private set; }

		public void Execute(string type, string data)
		{
			LogManager.GetCurrentClassLogger().Warn("Hello world!");

			Console.WriteLine(String.Format("{0}: {1}", type, data));
		}

		public void PutFile(PutFileMessage msg)
		{
			FileService.PutFile(msg);
		}
	}
}