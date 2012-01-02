using System;
using System.IO;
using JustDeploy.DI;
using JustDeploy.DeploymentControllerLib.ServiceClients;
using JustDeploy.IO;
using JustDeploy.IO.WcfFileTrans;

namespace JustDeploy.DeploymentControllerLib
{
	public class Class1
	{
		public Class1()
		{
			StreamTools = InstanceFactory.Get<IStreamTools>();
		}

		public Class1(IStreamTools streamTools)
		{
			StreamTools = streamTools;
		}

		protected IStreamTools StreamTools { get; private set; }

		public void DoStuff()
		{
			var agent = new AgentServiceClient();

			agent.Execute("hello", "world");
		}

		public void TransferFile()
		{
			const string fileName = @"c:\temp\MyFile.exe";


			Console.Write("Transferring File...");
			using (var putfile = new FileStream(fileName, FileMode.Open))
			{
				//Stream incomingFile = null;
				var fileTransfer = new FileServiceClient();
				fileTransfer.PutFile("Output.exe", putfile);
			}

			Console.WriteLine("Done!!");
		}
	}
}
