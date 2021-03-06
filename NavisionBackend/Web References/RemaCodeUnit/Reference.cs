﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace NavisionBackend.RemaCodeUnit {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="RemaCustomerCodeUnit_Binding", Namespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit")]
    public partial class RemaCustomerCodeUnit : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCustomerNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback CapitalizeOperationCompleted;
        
        private System.Threading.SendOrPostCallback CustomerLoginOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public RemaCustomerCodeUnit() {
            this.Url = global::NavisionBackend.Properties.Settings.Default.NavisionBackend_RemaCodeUnit_RemaCustomerCodeUnit;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCustomerNameCompletedEventHandler GetCustomerNameCompleted;
        
        /// <remarks/>
        public event CapitalizeCompletedEventHandler CapitalizeCompleted;
        
        /// <remarks/>
        public event CustomerLoginCompletedEventHandler CustomerLoginCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit:GetCustomerName", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", ResponseElementName="GetCustomerName_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string GetCustomerName(string customerID) {
            object[] results = this.Invoke("GetCustomerName", new object[] {
                        customerID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetCustomerNameAsync(string customerID) {
            this.GetCustomerNameAsync(customerID, null);
        }
        
        /// <remarks/>
        public void GetCustomerNameAsync(string customerID, object userState) {
            if ((this.GetCustomerNameOperationCompleted == null)) {
                this.GetCustomerNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCustomerNameOperationCompleted);
            }
            this.InvokeAsync("GetCustomerName", new object[] {
                        customerID}, this.GetCustomerNameOperationCompleted, userState);
        }
        
        private void OnGetCustomerNameOperationCompleted(object arg) {
            if ((this.GetCustomerNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCustomerNameCompleted(this, new GetCustomerNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit:Capitalize", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", ResponseElementName="Capitalize_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string Capitalize(string input) {
            object[] results = this.Invoke("Capitalize", new object[] {
                        input});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CapitalizeAsync(string input) {
            this.CapitalizeAsync(input, null);
        }
        
        /// <remarks/>
        public void CapitalizeAsync(string input, object userState) {
            if ((this.CapitalizeOperationCompleted == null)) {
                this.CapitalizeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCapitalizeOperationCompleted);
            }
            this.InvokeAsync("Capitalize", new object[] {
                        input}, this.CapitalizeOperationCompleted, userState);
        }
        
        private void OnCapitalizeOperationCompleted(object arg) {
            if ((this.CapitalizeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CapitalizeCompleted(this, new CapitalizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit:CustomerLogin", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", ResponseElementName="CustomerLogin_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/RemaCustomerCodeUnit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string CustomerLogin(string email) {
            object[] results = this.Invoke("CustomerLogin", new object[] {
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CustomerLoginAsync(string email) {
            this.CustomerLoginAsync(email, null);
        }
        
        /// <remarks/>
        public void CustomerLoginAsync(string email, object userState) {
            if ((this.CustomerLoginOperationCompleted == null)) {
                this.CustomerLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCustomerLoginOperationCompleted);
            }
            this.InvokeAsync("CustomerLogin", new object[] {
                        email}, this.CustomerLoginOperationCompleted, userState);
        }
        
        private void OnCustomerLoginOperationCompleted(object arg) {
            if ((this.CustomerLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CustomerLoginCompleted(this, new CustomerLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetCustomerNameCompletedEventHandler(object sender, GetCustomerNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCustomerNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCustomerNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CapitalizeCompletedEventHandler(object sender, CapitalizeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CapitalizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CapitalizeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CustomerLoginCompletedEventHandler(object sender, CustomerLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CustomerLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CustomerLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591