using System.Collections.Generic;

namespace JustDeploy.Commands
{
	public class ExecuteCommandOpts
	{
		public string CommandName { get; set; }
		public string WorkingDir { get; set; }
		public IEnumerable<string> Parameters { get; set; } 
	}
}