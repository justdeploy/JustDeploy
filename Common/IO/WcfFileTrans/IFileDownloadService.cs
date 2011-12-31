using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	[ServiceContract(Namespace = Application.WcfNamespace)]
	public interface IFileDownloadService
	{
		[OperationContract(IsOneWay = false)]
		void DownloadFile(FileDownloadMessage request);
	}
}