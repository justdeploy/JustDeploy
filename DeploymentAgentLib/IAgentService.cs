using System.ServiceModel;

namespace JustDeploy.DeploymentAgentLib
{

	[ServiceContract(Namespace = "http://justdeploy.nexia.ca/schema/")]
	public interface IAgentService
	{
		[OperationContract]
		void Execute(string command, string data);
	}
}
