using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JustDeploy.DeploymentAgent
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyCoolService" in both code and config file together.
	[ServiceContract(Namespace = "http://justdeploy.nexia.ca/schema/")]
	public interface IMyCoolService
	{
		[OperationContract]
		void DoWork();
	}
}
