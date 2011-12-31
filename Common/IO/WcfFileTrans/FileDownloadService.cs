using System;
using System.Configuration;
using System.IO;
using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	public class FileDownloadService : IFileDownloadService
	{
		public FileDownloadService(IStreamTools streamTools)
		{
			StreamTools = streamTools;
		}

		protected IStreamTools StreamTools { get; private set; }

		public void DownloadFile(FileDownloadMessage request)
		{
			// parameters validation omitted for clarity
			try
			{
				string basePath = ConfigurationManager.AppSettings["FileTransferPath"];
				string serverFileName = Path.Combine(basePath, request.FileMetaData.RemoteFilename);

				using (var outfile = new FileStream(serverFileName, FileMode.Create))
				{
					
					StreamTools.BufferedCopyStream(request.FileByteStream, outfile);
				} 
			}
			catch (IOException e)
			{
				throw new FaultException<IOException>(e);
			}
		}
	}
}