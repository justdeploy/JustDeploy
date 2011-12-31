using System.IO;
using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	[MessageContract]
	public class FileUploadMessage
	{
		[MessageBodyMember(Order = 1)]
		public Stream FileByteStream;

		[MessageHeader(MustUnderstand = true)]
		public FileMetaData FileMetaData;
	}
}