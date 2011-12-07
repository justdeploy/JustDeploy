using System.IO;

namespace JustDeploy.IO
{
	public interface IStreamTools
	{
		void CopyStream(Stream input, Stream output, int bufferSize = 32*1024);
	}
}