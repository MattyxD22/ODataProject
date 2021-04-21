﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductCodeUnitRema
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", ConfigurationName="ProductCodeUnitRema.ProducCodeUnitRema_Port")]
    public interface ProducCodeUnitRema_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema:Product", ReplyAction="*")]
        System.Threading.Tasks.Task<ProductCodeUnitRema.Product_Result> ProductAsync(ProductCodeUnitRema.Product request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema:Price", ReplyAction="*")]
        System.Threading.Tasks.Task<ProductCodeUnitRema.Price_Result> PriceAsync(ProductCodeUnitRema.Price request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Product", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", IsWrapped=true)]
    public partial class Product
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", Order=0)]
        public string barcode;
        
        public Product()
        {
        }
        
        public Product(string barcode)
        {
            this.barcode = barcode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Product_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", IsWrapped=true)]
    public partial class Product_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", Order=0)]
        public string return_value;
        
        public Product_Result()
        {
        }
        
        public Product_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Price", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", IsWrapped=true)]
    public partial class Price
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", Order=0)]
        public string barcode;
        
        public Price()
        {
        }
        
        public Price(string barcode)
        {
            this.barcode = barcode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Price_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", IsWrapped=true)]
    public partial class Price_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ProducCodeUnitRema", Order=0)]
        public string return_value;
        
        public Price_Result()
        {
        }
        
        public Price_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ProducCodeUnitRema_PortChannel : ProductCodeUnitRema.ProducCodeUnitRema_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ProducCodeUnitRema_PortClient : System.ServiceModel.ClientBase<ProductCodeUnitRema.ProducCodeUnitRema_Port>, ProductCodeUnitRema.ProducCodeUnitRema_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ProducCodeUnitRema_PortClient() : 
                base(ProducCodeUnitRema_PortClient.GetDefaultBinding(), ProducCodeUnitRema_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ProducCodeUnitRema_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProducCodeUnitRema_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(ProducCodeUnitRema_PortClient.GetBindingForEndpoint(endpointConfiguration), ProducCodeUnitRema_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProducCodeUnitRema_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ProducCodeUnitRema_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProducCodeUnitRema_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ProducCodeUnitRema_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProducCodeUnitRema_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProductCodeUnitRema.Product_Result> ProductCodeUnitRema.ProducCodeUnitRema_Port.ProductAsync(ProductCodeUnitRema.Product request)
        {
            return base.Channel.ProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProductCodeUnitRema.Product_Result> ProductAsync(string barcode)
        {
            ProductCodeUnitRema.Product inValue = new ProductCodeUnitRema.Product();
            inValue.barcode = barcode;
            return ((ProductCodeUnitRema.ProducCodeUnitRema_Port)(this)).ProductAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProductCodeUnitRema.Price_Result> ProductCodeUnitRema.ProducCodeUnitRema_Port.PriceAsync(ProductCodeUnitRema.Price request)
        {
            return base.Channel.PriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProductCodeUnitRema.Price_Result> PriceAsync(string barcode)
        {
            ProductCodeUnitRema.Price inValue = new ProductCodeUnitRema.Price();
            inValue.barcode = barcode;
            return ((ProductCodeUnitRema.ProducCodeUnitRema_Port)(this)).PriceAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.ProducCodeUnitRema_Port))
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
            if ((endpointConfiguration == EndpointConfiguration.ProducCodeUnitRema_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://mathias:7047/BC140/WS/CRONUS International Ltd./Codeunit/ProducCodeUnitRem" +
                        "a");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ProducCodeUnitRema_PortClient.GetBindingForEndpoint(EndpointConfiguration.ProducCodeUnitRema_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ProducCodeUnitRema_PortClient.GetEndpointAddress(EndpointConfiguration.ProducCodeUnitRema_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            ProducCodeUnitRema_Port,
        }
    }
}