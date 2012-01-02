using System;

namespace JustDeploy.IO.WcfFileTrans
{
	//public delegate void FileEventHandler(object sender, FileEventArgs e);

	public class FileEventArgs : EventArgs
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FileEventArgs"/> class.
		/// </summary>
		/// <param name="virtualPath">The v path.</param>
		public FileEventArgs(string virtualPath)
		{
			VirtualPath = virtualPath;
		}

		public string VirtualPath { get; private set; }		
	}
}