﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace JustDeploy.DeploymentControllerLib.ServiceClients
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.nexia.ca/justdeploy/2011/12/", ConfigurationName="JustDeploy.DeploymentControllerLib.ServiceClients.IAgentService")]
    public interface IAgentService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.nexia.ca/justdeploy/2011/12/IAgentService/Execute", ReplyAction="http://schemas.nexia.ca/justdeploy/2011/12/IAgentService/ExecuteResponse")]
        void Execute(string command, string data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAgentServiceChannel : JustDeploy.DeploymentControllerLib.ServiceClients.IAgentService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgentServiceClient : System.ServiceModel.ClientBase<JustDeploy.DeploymentControllerLib.ServiceClients.IAgentService>, JustDeploy.DeploymentControllerLib.ServiceClients.IAgentService
    {
        
        public AgentServiceClient()
        {
        }
        
        public AgentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public AgentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public AgentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public AgentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void Execute(string command, string data)
        {
            base.Channel.Execute(command, data);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.nexia.ca/justdeploy/2011/12/", ConfigurationName="JustDeploy.DeploymentControllerLib.ServiceClients.IFileService")]
    public interface IFileService
    {
        
        // CODEGEN: Generating message contract since the operation PutFile is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.nexia.ca/justdeploy/2011/12/IFileService/PutFile", ReplyAction="http://schemas.nexia.ca/justdeploy/2011/12/IFileService/PutFileResponse")]
        JustDeploy.DeploymentControllerLib.ServiceClients.PutFileResponse PutFile(JustDeploy.DeploymentControllerLib.ServiceClients.PutFileMessage request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PutFileMessage", WrapperNamespace="http://schemas.nexia.ca/justdeploy/2011/12/", IsWrapped=true)]
    public partial class PutFileMessage
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.nexia.ca/justdeploy/2011/12/")]
        public string VirtualPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.nexia.ca/justdeploy/2011/12/", Order=0)]
        public System.IO.Stream DataStream;
        
        public PutFileMessage()
        {
        }
        
        public PutFileMessage(string VirtualPath, System.IO.Stream DataStream)
        {
            this.VirtualPath = VirtualPath;
            this.DataStream = DataStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PutFileResponse
    {
        
        public PutFileResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : JustDeploy.DeploymentControllerLib.ServiceClients.IFileService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<JustDeploy.DeploymentControllerLib.ServiceClients.IFileService>, JustDeploy.DeploymentControllerLib.ServiceClients.IFileService
    {
        
        public FileServiceClient()
        {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JustDeploy.DeploymentControllerLib.ServiceClients.PutFileResponse JustDeploy.DeploymentControllerLib.ServiceClients.IFileService.PutFile(JustDeploy.DeploymentControllerLib.ServiceClients.PutFileMessage request)
        {
            return base.Channel.PutFile(request);
        }
        
        public void PutFile(string VirtualPath, System.IO.Stream DataStream)
        {
            JustDeploy.DeploymentControllerLib.ServiceClients.PutFileMessage inValue = new JustDeploy.DeploymentControllerLib.ServiceClients.PutFileMessage();
            inValue.VirtualPath = VirtualPath;
            inValue.DataStream = DataStream;
            JustDeploy.DeploymentControllerLib.ServiceClients.PutFileResponse retVal = ((JustDeploy.DeploymentControllerLib.ServiceClients.IFileService)(this)).PutFile(inValue);
        }
    }
}