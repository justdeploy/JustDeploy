using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	[ServiceContract(Namespace = Application.WcfNamespace)]
	public interface IFileService
	{
		[OperationContract]
		void PutFile(PutFileMessage msg);
	}
}