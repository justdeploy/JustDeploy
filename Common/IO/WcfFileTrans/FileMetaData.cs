using System.Runtime.Serialization;

namespace JustDeploy.IO.WcfFileTrans
{
	[DataContract(Namespace = Application.WcfNamespace)]
	public class FileMetaData
	{
		public FileMetaData(string localFileName, string remoteFileName)
		{
			LocalFilename = localFileName;
			RemoteFilename = remoteFileName;
		}

		[DataMember(Name = "LocalFilename", Order = 0, IsRequired = false)]
		public string LocalFilename;

		[DataMember(Name = "RemoteFilename", Order = 1, IsRequired = false)]
		public string RemoteFilename;
	}
}