﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Endpoint_Client.ContextHandler {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
    [System.SerializableAttribute()]
    public partial class AltinnFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AltinnErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AltinnExtendedErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AltinnLocalizedErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorGuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserGuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AltinnErrorMessage {
            get {
                return this.AltinnErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnErrorMessageField, value) != true)) {
                    this.AltinnErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AltinnExtendedErrorMessage {
            get {
                return this.AltinnExtendedErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnExtendedErrorMessageField, value) != true)) {
                    this.AltinnExtendedErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnExtendedErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AltinnLocalizedErrorMessage {
            get {
                return this.AltinnLocalizedErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnLocalizedErrorMessageField, value) != true)) {
                    this.AltinnLocalizedErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnLocalizedErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorGuid {
            get {
                return this.ErrorGuidField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorGuidField, value) != true)) {
                    this.ErrorGuidField = value;
                    this.RaisePropertyChanged("ErrorGuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorID {
            get {
                return this.ErrorIDField;
            }
            set {
                if ((this.ErrorIDField.Equals(value) != true)) {
                    this.ErrorIDField = value;
                    this.RaisePropertyChanged("ErrorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserGuid {
            get {
                return this.UserGuidField;
            }
            set {
                if ((object.ReferenceEquals(this.UserGuidField, value) != true)) {
                    this.UserGuidField = value;
                    this.RaisePropertyChanged("UserGuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReporteeElementContextExternalBE", Namespace="http://www.altinn.no/services/ServiceEngine/ReporteeElementContext/2014/10")]
    [System.SerializableAttribute()]
    public partial class ReporteeElementContextExternalBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ProcessStepIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReporteeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ServiceEditionCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EC_Endpoint_Client.ContextHandler.ServiceType ServiceTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ProcessStepID {
            get {
                return this.ProcessStepIDField;
            }
            set {
                if ((this.ProcessStepIDField.Equals(value) != true)) {
                    this.ProcessStepIDField = value;
                    this.RaisePropertyChanged("ProcessStepID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reportee {
            get {
                return this.ReporteeField;
            }
            set {
                if ((object.ReferenceEquals(this.ReporteeField, value) != true)) {
                    this.ReporteeField = value;
                    this.RaisePropertyChanged("Reportee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceCode {
            get {
                return this.ServiceCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceCodeField, value) != true)) {
                    this.ServiceCodeField = value;
                    this.RaisePropertyChanged("ServiceCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ServiceEditionCode {
            get {
                return this.ServiceEditionCodeField;
            }
            set {
                if ((this.ServiceEditionCodeField.Equals(value) != true)) {
                    this.ServiceEditionCodeField = value;
                    this.RaisePropertyChanged("ServiceEditionCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EC_Endpoint_Client.ContextHandler.ServiceType ServiceType {
            get {
                return this.ServiceTypeField;
            }
            set {
                if ((this.ServiceTypeField.Equals(value) != true)) {
                    this.ServiceTypeField = value;
                    this.RaisePropertyChanged("ServiceType");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceType", Namespace="http://schemas.altinn.no/ServiceDevelopment/Service/2009/10")]
    public enum ServiceType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Correspondence = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Reporting = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Collaboration = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Lookup = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Link = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/ContextHandler/2014/10", ConfigurationName="ContextHandler.IContextHandlerEC")]
    public interface IContextHandlerEC {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/ServiceEngine/ContextHandler/2014/10)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.ContextHandler.AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.ContextHandler.TestResponse Test(EC_Endpoint_Client.ContextHandler.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<EC_Endpoint_Client.ContextHandler.TestResponse> TestAsync(EC_Endpoint_Client.ContextHandler.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/ContextHandler/2014/10/IContextHandle" +
            "rEC/GetReporteeElementContextExternalEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/ContextHandler/2014/10/IContextHandle" +
            "rEC/GetReporteeElementContextExternalECResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.ContextHandler.AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/ContextHandler/2014/10/IContextHandle" +
            "rEC/GetReporteeElementContextExternalECAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.ContextHandler.ReporteeElementContextExternalBE GetReporteeElementContextExternalEC(string systemUserName, string systemPassword, int reporteeElementID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/ContextHandler/2014/10/IContextHandle" +
            "rEC/GetReporteeElementContextExternalEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/ContextHandler/2014/10/IContextHandle" +
            "rEC/GetReporteeElementContextExternalECResponse")]
        System.Threading.Tasks.Task<EC_Endpoint_Client.ContextHandler.ReporteeElementContextExternalBE> GetReporteeElementContextExternalECAsync(string systemUserName, string systemPassword, int reporteeElementID);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Test", WrapperNamespace="http://www.altinn.no/services/2009/10", IsWrapped=true)]
    public partial class TestRequest {
        
        public TestRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestResponse", WrapperNamespace="http://www.altinn.no/services/2009/10", IsWrapped=true)]
    public partial class TestResponse {
        
        public TestResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContextHandlerECChannel : EC_Endpoint_Client.ContextHandler.IContextHandlerEC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContextHandlerECClient : System.ServiceModel.ClientBase<EC_Endpoint_Client.ContextHandler.IContextHandlerEC>, EC_Endpoint_Client.ContextHandler.IContextHandlerEC {
        
        public ContextHandlerECClient() {
        }
        
        public ContextHandlerECClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContextHandlerECClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContextHandlerECClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContextHandlerECClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.ContextHandler.TestResponse EC_Endpoint_Client.ContextHandler.IContextHandlerEC.Test(EC_Endpoint_Client.ContextHandler.TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            EC_Endpoint_Client.ContextHandler.TestRequest inValue = new EC_Endpoint_Client.ContextHandler.TestRequest();
            EC_Endpoint_Client.ContextHandler.TestResponse retVal = ((EC_Endpoint_Client.ContextHandler.IContextHandlerEC)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EC_Endpoint_Client.ContextHandler.TestResponse> EC_Endpoint_Client.ContextHandler.IContextHandlerEC.TestAsync(EC_Endpoint_Client.ContextHandler.TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<EC_Endpoint_Client.ContextHandler.TestResponse> TestAsync() {
            EC_Endpoint_Client.ContextHandler.TestRequest inValue = new EC_Endpoint_Client.ContextHandler.TestRequest();
            return ((EC_Endpoint_Client.ContextHandler.IContextHandlerEC)(this)).TestAsync(inValue);
        }
        
        public EC_Endpoint_Client.ContextHandler.ReporteeElementContextExternalBE GetReporteeElementContextExternalEC(string systemUserName, string systemPassword, int reporteeElementID) {
            return base.Channel.GetReporteeElementContextExternalEC(systemUserName, systemPassword, reporteeElementID);
        }
        
        public System.Threading.Tasks.Task<EC_Endpoint_Client.ContextHandler.ReporteeElementContextExternalBE> GetReporteeElementContextExternalECAsync(string systemUserName, string systemPassword, int reporteeElementID) {
            return base.Channel.GetReporteeElementContextExternalECAsync(systemUserName, systemPassword, reporteeElementID);
        }
    }
}
