using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeploymentControllerLib
{
	public class Class1
	{

		public void DoStuff()
		{
			var agent = new AgentServiceClient();

			agent.Execute("hello", "world");
		}
	}
}
