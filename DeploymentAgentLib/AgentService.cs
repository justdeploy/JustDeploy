using System;
using System.IO;

namespace JustDeploy.DeploymentAgentLib
{
	public class AgentService : IAgentService
	{
		public void Execute(string command, string data)
		{
			Console.WriteLine(String.Format("{0}: {1}", command, data));
		}

		public void TransferStream(Stream fileStream)
		{
			foreach(var bytes in file)
		}
	}
}