using System.Configuration;
using System.IO;
using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	public class FileUploadService : IFileUploadService
	{
		public FileDownloadReturnMessage UploadFile(FileUploadMessage request)
		{
			// parameters validation omitted for clarity
			string localFileName = request.FileMetaData.LocalFilename;

			try
			{
				string basePath = ConfigurationManager.AppSettings["FileTransferPath"];
				string serverFileName = Path.Combine(basePath, request.FileMetaData.RemoteFilename);

				var fs = new FileStream(serverFileName, FileMode.Open);

				return new FileDownloadReturnMessage(new FileMetaData(localFileName, serverFileName), fs);
			}
			catch (IOException e)
			{
				throw new FaultException<IOException>(e);
			}
		}
	}
}