using System.IO;
using System.ServiceModel;

namespace JustDeploy.IO.WcfFileTrans
{
	[MessageContract]
	public class PutFileMessage
	{
		[MessageHeader(MustUnderstand = true)]
		public string VirtualPath { get; set; }

		[MessageBodyMember(Order = 1)]
		public Stream DataStream { get; set; }
	}
}