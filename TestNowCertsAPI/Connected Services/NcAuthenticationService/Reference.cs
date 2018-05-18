﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestNowCertsAPI.NcAuthenticationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.nowcerts.com/", ConfigurationName="NcAuthenticationService.AuthenticationServiceSoap")]
    public interface AuthenticationServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.nowcerts.com/GetToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        TestNowCertsAPI.NcAuthenticationService.AuthenticationData GetToken(TestNowCertsAPI.NcAuthenticationService.LoginData loginData);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.nowcerts.com/GetToken", ReplyAction="*")]
        System.Threading.Tasks.Task<TestNowCertsAPI.NcAuthenticationService.AuthenticationData> GetTokenAsync(TestNowCertsAPI.NcAuthenticationService.LoginData loginData);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.nowcerts.com/")]
    public partial class LoginData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.nowcerts.com/")]
    public partial class AuthenticationData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tokenField;
        
        private System.DateTime expiresOnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("Token");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime ExpiresOn {
            get {
                return this.expiresOnField;
            }
            set {
                this.expiresOnField = value;
                this.RaisePropertyChanged("ExpiresOn");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthenticationServiceSoapChannel : TestNowCertsAPI.NcAuthenticationService.AuthenticationServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationServiceSoapClient : System.ServiceModel.ClientBase<TestNowCertsAPI.NcAuthenticationService.AuthenticationServiceSoap>, TestNowCertsAPI.NcAuthenticationService.AuthenticationServiceSoap {
        
        public AuthenticationServiceSoapClient() {
        }
        
        public AuthenticationServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestNowCertsAPI.NcAuthenticationService.AuthenticationData GetToken(TestNowCertsAPI.NcAuthenticationService.LoginData loginData) {
            return base.Channel.GetToken(loginData);
        }
        
        public System.Threading.Tasks.Task<TestNowCertsAPI.NcAuthenticationService.AuthenticationData> GetTokenAsync(TestNowCertsAPI.NcAuthenticationService.LoginData loginData) {
            return base.Channel.GetTokenAsync(loginData);
        }
    }
}
