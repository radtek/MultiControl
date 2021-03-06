﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMEConnector.SMEServiceReferenceLogin {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginInput", Namespace="http://wistron.com/webservices/")]
    [System.SerializableAttribute()]
    public partial class LoginInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassWordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string PassWord {
            get {
                return this.PassWordField;
            }
            set {
                if ((object.ReferenceEquals(this.PassWordField, value) != true)) {
                    this.PassWordField = value;
                    this.RaisePropertyChanged("PassWord");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginOutput", Namespace="http://wistron.com/webservices/")]
    [System.SerializableAttribute()]
    public partial class LoginOutput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool SuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMsgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ErrorMsg {
            get {
                return this.ErrorMsgField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMsgField, value) != true)) {
                    this.ErrorMsgField = value;
                    this.RaisePropertyChanged("ErrorMsg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIdField, value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
                }
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://wistron.com/webservices/", ConfigurationName="SMEServiceReferenceLogin.AuthenticateSoap")]
    public interface AuthenticateSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://wistron.com/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://wistron.com/webservices/HelloWorld", ReplyAction="*")]
        SMEConnector.SMEServiceReferenceLogin.HelloWorldResponse HelloWorld(SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wistron.com/webservices/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<SMEConnector.SMEServiceReferenceLogin.HelloWorldResponse> HelloWorldAsync(SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name loginInput from namespace http://wistron.com/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://wistron.com/webservices/Login", ReplyAction="*")]
        SMEConnector.SMEServiceReferenceLogin.LoginResponse Login(SMEConnector.SMEServiceReferenceLogin.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wistron.com/webservices/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<SMEConnector.SMEServiceReferenceLogin.LoginResponse> LoginAsync(SMEConnector.SMEServiceReferenceLogin.LoginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://wistron.com/webservices/", Order=0)]
        public SMEConnector.SMEServiceReferenceLogin.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(SMEConnector.SMEServiceReferenceLogin.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://wistron.com/webservices/", Order=0)]
        public SMEConnector.SMEServiceReferenceLogin.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(SMEConnector.SMEServiceReferenceLogin.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://wistron.com/webservices/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://wistron.com/webservices/", Order=0)]
        public SMEConnector.SMEServiceReferenceLogin.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(SMEConnector.SMEServiceReferenceLogin.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://wistron.com/webservices/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public SMEConnector.SMEServiceReferenceLogin.LoginInput loginInput;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(SMEConnector.SMEServiceReferenceLogin.LoginInput loginInput) {
            this.loginInput = loginInput;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://wistron.com/webservices/", Order=0)]
        public SMEConnector.SMEServiceReferenceLogin.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(SMEConnector.SMEServiceReferenceLogin.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://wistron.com/webservices/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public SMEConnector.SMEServiceReferenceLogin.LoginOutput LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(SMEConnector.SMEServiceReferenceLogin.LoginOutput LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthenticateSoapChannel : SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticateSoapClient : System.ServiceModel.ClientBase<SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap>, SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap {
        
        public AuthenticateSoapClient() {
        }
        
        public AuthenticateSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticateSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SMEConnector.SMEServiceReferenceLogin.HelloWorldResponse SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap.HelloWorld(SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest inValue = new SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest();
            inValue.Body = new SMEConnector.SMEServiceReferenceLogin.HelloWorldRequestBody();
            SMEConnector.SMEServiceReferenceLogin.HelloWorldResponse retVal = ((SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SMEConnector.SMEServiceReferenceLogin.HelloWorldResponse> SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap.HelloWorldAsync(SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<SMEConnector.SMEServiceReferenceLogin.HelloWorldResponse> HelloWorldAsync() {
            SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest inValue = new SMEConnector.SMEServiceReferenceLogin.HelloWorldRequest();
            inValue.Body = new SMEConnector.SMEServiceReferenceLogin.HelloWorldRequestBody();
            return ((SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SMEConnector.SMEServiceReferenceLogin.LoginResponse SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap.Login(SMEConnector.SMEServiceReferenceLogin.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public SMEConnector.SMEServiceReferenceLogin.LoginOutput Login(SMEConnector.SMEServiceReferenceLogin.LoginInput loginInput) {
            SMEConnector.SMEServiceReferenceLogin.LoginRequest inValue = new SMEConnector.SMEServiceReferenceLogin.LoginRequest();
            inValue.Body = new SMEConnector.SMEServiceReferenceLogin.LoginRequestBody();
            inValue.Body.loginInput = loginInput;
            SMEConnector.SMEServiceReferenceLogin.LoginResponse retVal = ((SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SMEConnector.SMEServiceReferenceLogin.LoginResponse> SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap.LoginAsync(SMEConnector.SMEServiceReferenceLogin.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<SMEConnector.SMEServiceReferenceLogin.LoginResponse> LoginAsync(SMEConnector.SMEServiceReferenceLogin.LoginInput loginInput) {
            SMEConnector.SMEServiceReferenceLogin.LoginRequest inValue = new SMEConnector.SMEServiceReferenceLogin.LoginRequest();
            inValue.Body = new SMEConnector.SMEServiceReferenceLogin.LoginRequestBody();
            inValue.Body.loginInput = loginInput;
            return ((SMEConnector.SMEServiceReferenceLogin.AuthenticateSoap)(this)).LoginAsync(inValue);
        }
    }
}
