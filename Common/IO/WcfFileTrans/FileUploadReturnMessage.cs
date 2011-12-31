using System.IO;
using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	[MessageContract]
	public class FileUploadReturnMessage
	{
		[MessageHeader(MustUnderstand = true)]
		public FileMetaData DownloadedFileMetadata;

		public FileUploadReturnMessage(FileMetaData metaData, Stream stream)
		{
			DownloadedFileMetadata = metaData;
			FileByteStream = stream;
		}
	}
}