using System.IO;
using System.ServiceModel;

namespace JustDeploy.DeploymentAgentLib
{

	[ServiceContract(Namespace = "http://justdeploy.nexia.ca/schema/v1/")]
	public interface IAgentService
	{
		[OperationContract]
		void Execute(string command, string data);

		[OperationContract]
		void TransferStream(Stream fileStream);
	}
}
