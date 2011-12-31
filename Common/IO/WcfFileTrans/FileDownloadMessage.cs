using System.IO;
using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	[MessageContract]
	public class FileDownloadMessage
	{
		[MessageHeader(MustUnderstand = true)]
		public FileMetaData FileMetaData;

		[MessageBodyMember(Order = 1)]
		public Stream FileByteStream;
	}
}