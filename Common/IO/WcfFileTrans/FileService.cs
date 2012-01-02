using System;
using System.Configuration;
using System.IO;

namespace JustDeploy.IO.WcfFileTrans
{
	public class FileService : IFileService
	{
		public FileService(IStreamTools streamTools)
		{
			StreamTools = streamTools;
		}

		protected IStreamTools StreamTools { get; private set; }

		public EventHandler<FileEventArgs> FileUploaded;

		public void PutFile(PutFileMessage msg)
		{
			string basePath = ConfigurationManager.AppSettings["FileTransferPath"];
			string filePath = Path.Combine(basePath, msg.VirtualPath);
			string dir = Path.GetDirectoryName(filePath);

			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			using (var outputStream = new FileStream(filePath, FileMode.Create))
			{
				StreamTools.BufferedCopyStream(msg.DataStream, outputStream);
			}
		}

		///  <summary>
		/// Raises the FileUploaded event
		///  </summary>
		protected void SendFileUploaded(string vPath)
		{
			if (FileUploaded != null)
				FileUploaded(this, new FileEventArgs(vPath));
		}
	}
}