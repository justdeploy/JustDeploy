using System.IO;

namespace JustDeploy.IO
{
	public class StreamTools : IStreamTools
	{
		public void CopyStream(Stream input, Stream output, int bufferSize = 32*1024)
		{
			var buffer = new byte[bufferSize];
			int bytesRead;
			while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
			{
				output.Write(buffer, 0, bytesRead);
			}
		}
	}
}
