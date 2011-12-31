using System.IO;
using System.ServiceModel;

namespace JustDeploy.DeploymentAgentLib
{

	[ServiceContract(Namespace = Application.WcfNamespace)]
	public interface IAgentService
	{
		[OperationContract]
		void Execute(string command, string data);

		[OperationContract]
		void TransferStream(Stream fileStream);
	}
}
