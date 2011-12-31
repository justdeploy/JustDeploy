using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	[ServiceContract(Namespace = Application.WcfNamespace)]
	public interface IFileUploadService
	{
		[OperationContract(IsOneWay = true)]
		FileDownloadReturnMessage UploadFile(FileUploadMessage request);
	}
}