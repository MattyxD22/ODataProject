﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemaCodeUnit
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", ConfigurationName="RemaCodeUnit.RemaCustomerCodeUnit_Port")]
    public interface RemaCustomerCodeUnit_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit:GetCustomerName", ReplyAction="*")]
        System.Threading.Tasks.Task<RemaCodeUnit.GetCustomerName_Result> GetCustomerNameAsync(RemaCodeUnit.GetCustomerName request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit:Capitalize", ReplyAction="*")]
        System.Threading.Tasks.Task<RemaCodeUnit.Capitalize_Result> CapitalizeAsync(RemaCodeUnit.Capitalize request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomerName", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", IsWrapped=true)]
    public partial class GetCustomerName
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", Order=0)]
        public string customerID;
        
        public GetCustomerName()
        {
        }
        
        public GetCustomerName(string customerID)
        {
            this.customerID = customerID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomerName_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", IsWrapped=true)]
    public partial class GetCustomerName_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", Order=0)]
        public string return_value;
        
        public GetCustomerName_Result()
        {
        }
        
        public GetCustomerName_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Capitalize", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", IsWrapped=true)]
    public partial class Capitalize
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", Order=0)]
        public string input;
        
        public Capitalize()
        {
        }
        
        public Capitalize(string input)
        {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Capitalize_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", IsWrapped=true)]
    public partial class Capitalize_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", Order=0)]
        public string return_value;
        
        public Capitalize_Result()
        {
        }
        
        public Capitalize_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface RemaCustomerCodeUnit_PortChannel : RemaCodeUnit.RemaCustomerCodeUnit_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class RemaCustomerCodeUnit_PortClient : System.ServiceModel.ClientBase<RemaCodeUnit.RemaCustomerCodeUnit_Port>, RemaCodeUnit.RemaCustomerCodeUnit_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public RemaCustomerCodeUnit_PortClient() : 
                base(RemaCustomerCodeUnit_PortClient.GetDefaultBinding(), RemaCustomerCodeUnit_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.RemaCustomerCodeUnit_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemaCustomerCodeUnit_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(RemaCustomerCodeUnit_PortClient.GetBindingForEndpoint(endpointConfiguration), RemaCustomerCodeUnit_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemaCustomerCodeUnit_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(RemaCustomerCodeUnit_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemaCustomerCodeUnit_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(RemaCustomerCodeUnit_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemaCustomerCodeUnit_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RemaCodeUnit.GetCustomerName_Result> RemaCodeUnit.RemaCustomerCodeUnit_Port.GetCustomerNameAsync(RemaCodeUnit.GetCustomerName request)
        {
            return base.Channel.GetCustomerNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<RemaCodeUnit.GetCustomerName_Result> GetCustomerNameAsync(string customerID)
        {
            RemaCodeUnit.GetCustomerName inValue = new RemaCodeUnit.GetCustomerName();
            inValue.customerID = customerID;
            return ((RemaCodeUnit.RemaCustomerCodeUnit_Port)(this)).GetCustomerNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RemaCodeUnit.Capitalize_Result> RemaCodeUnit.RemaCustomerCodeUnit_Port.CapitalizeAsync(RemaCodeUnit.Capitalize request)
        {
            return base.Channel.CapitalizeAsync(request);
        }
        
        public System.Threading.Tasks.Task<RemaCodeUnit.Capitalize_Result> CapitalizeAsync(string input)
        {
            RemaCodeUnit.Capitalize inValue = new RemaCodeUnit.Capitalize();
            inValue.input = input;
            return ((RemaCodeUnit.RemaCustomerCodeUnit_Port)(this)).CapitalizeAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RemaCustomerCodeUnit_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RemaCustomerCodeUnit_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://mathias:7047/BC140/WS/CRONUS International Ltd./Codeunit/RemaCustomerCodeU" +
                        "nit");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return RemaCustomerCodeUnit_PortClient.GetBindingForEndpoint(EndpointConfiguration.RemaCustomerCodeUnit_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return RemaCustomerCodeUnit_PortClient.GetEndpointAddress(EndpointConfiguration.RemaCustomerCodeUnit_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            RemaCustomerCodeUnit_Port,
        }
    }
}
