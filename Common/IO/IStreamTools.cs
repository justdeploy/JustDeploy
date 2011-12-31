using System.IO;

namespace JustDeploy.IO
{
	public interface IStreamTools
	{
		void BufferedCopyStream(Stream input, Stream output, int bufferSize = 32*1024);
	}
}