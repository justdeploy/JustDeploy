using System;
using JustDeploy.IO;

namespace JustDeploy.Commands
{
	public abstract class CommandBase<T> : ICommand<T> where T : class
	{
		public string Name { get; set; }
		public string Data { get; set; }
		public string Type { get; set; }

		public T GetExtraData()
		{
			return String.IsNullOrEmpty(Data) ? null : Json.From<T>(Data);
		}
	}
}
