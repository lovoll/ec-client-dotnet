﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace EC_Endpoint_Client.Service_References.BrokerServiceStreamed {
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
    [Serializable()]
    public partial class AltinnFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [NonSerialized()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [OptionalField()]
        private string AltinnErrorMessageField;
        
        [OptionalField()]
        private string AltinnExtendedErrorMessageField;
        
        [OptionalField()]
        private string AltinnLocalizedErrorMessageField;
        
        [OptionalField()]
        private string ErrorGuidField;
        
        [OptionalField()]
        private int ErrorIDField;
        
        [OptionalField()]
        private string UserGuidField;
        
        [OptionalField()]
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
        
        [DataMember()]
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
        
        [DataMember()]
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
        
        [DataMember()]
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
        
        [DataMember()]
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
        
        [DataMember()]
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
        
        [DataMember()]
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
        
        [DataMember()]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", ConfigurationName="BrokerServiceStreamed.IBrokerServiceExternalECStreamed")]
    public interface IBrokerServiceExternalECStreamed {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/ServiceEngine/Broker/2015/06)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        TestResponse Test(TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<TestResponse> TestAsync(TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/UploadFileStreamedEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/UploadFileStreamedECResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/UploadFileStreamedECAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        ReceiptExternalStreamedBE UploadFileStreamedEC(StreamedPayloadECBE request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/UploadFileStreamedEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/UploadFileStreamedECResponse")]
        System.Threading.Tasks.Task<ReceiptExternalStreamedBE> UploadFileStreamedECAsync(StreamedPayloadECBE request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/ServiceEngine/Broker/2015/06 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/DownloadFileStreamedEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/DownloadFileStreamedECResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/DownloadFileStreamedECAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        DownloadFileStreamedECResponse DownloadFileStreamedEC(DownloadFileStreamedECRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/DownloadFileStreamedEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Broker/2015/06/IBrokerServiceExternal" +
            "ECStreamed/DownloadFileStreamedECResponse")]
        System.Threading.Tasks.Task<DownloadFileStreamedECResponse> DownloadFileStreamedECAsync(DownloadFileStreamedECRequest request);
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StreamedPayloadECBE", WrapperNamespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", IsWrapped=true)]
    public partial class StreamedPayloadECBE {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06")]
        public string Password;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06")]
        public string Reference;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06")]
        public string Reportee;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06")]
        public string UserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=0)]
        public System.IO.Stream DataStream;
        
        public StreamedPayloadECBE() {
        }
        
        public StreamedPayloadECBE(string FileName, string Password, string Reference, string Reportee, string UserName, System.IO.Stream DataStream) {
            this.FileName = FileName;
            this.Password = Password;
            this.Reference = Reference;
            this.Reportee = Reportee;
            this.UserName = UserName;
            this.DataStream = DataStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReceiptExternalStreamedBE", WrapperNamespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", IsWrapped=true)]
    public partial class ReceiptExternalStreamedBE {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=0)]
        public string LastChanged;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=1)]
        public int ParentReceiptId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=2)]
        public string ReceiptHistory;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=3)]
        public int ReceiptId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=4)]
        public string ReceiptStatusCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=5)]
        public string ReceiptText;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=6)]
        public string ReceiptTypeName;
        
        public ReceiptExternalStreamedBE() {
        }
        
        public ReceiptExternalStreamedBE(string LastChanged, int ParentReceiptId, string ReceiptHistory, int ReceiptId, string ReceiptStatusCode, string ReceiptText, string ReceiptTypeName) {
            this.LastChanged = LastChanged;
            this.ParentReceiptId = ParentReceiptId;
            this.ReceiptHistory = ReceiptHistory;
            this.ReceiptId = ReceiptId;
            this.ReceiptStatusCode = ReceiptStatusCode;
            this.ReceiptText = ReceiptText;
            this.ReceiptTypeName = ReceiptTypeName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DownloadFileStreamedECRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DownloadFileStreamedEC", Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=0)]
        public DownloadFileStreamedECRequestBody Body;
        
        public DownloadFileStreamedECRequest() {
        }
        
        public DownloadFileStreamedECRequest(DownloadFileStreamedECRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06")]
    public partial class DownloadFileStreamedECRequestBody {
        
        [DataMember(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [DataMember(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [DataMember(EmitDefaultValue=false, Order=2)]
        public string fileReference;
        
        [DataMember(EmitDefaultValue=false, Order=3)]
        public string reportee;
        
        public DownloadFileStreamedECRequestBody() {
        }
        
        public DownloadFileStreamedECRequestBody(string userName, string password, string fileReference, string reportee) {
            this.userName = userName;
            this.password = password;
            this.fileReference = fileReference;
            this.reportee = reportee;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DownloadFileStreamedECResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DownloadFileStreamedECResponse", Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06", Order=0)]
        public DownloadFileStreamedECResponseBody Body;
        
        public DownloadFileStreamedECResponse() {
        }
        
        public DownloadFileStreamedECResponse(DownloadFileStreamedECResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Broker/2015/06")]
    public partial class DownloadFileStreamedECResponseBody {
        
        [DataMember(Order=0)]
        public byte[] DownloadFileStreamedECResult;
        
        public DownloadFileStreamedECResponseBody() {
        }
        
        public DownloadFileStreamedECResponseBody(byte[] DownloadFileStreamedECResult) {
            this.DownloadFileStreamedECResult = DownloadFileStreamedECResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBrokerServiceExternalECStreamedChannel : IBrokerServiceExternalECStreamed, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BrokerServiceExternalECStreamedClient : System.ServiceModel.ClientBase<IBrokerServiceExternalECStreamed>, IBrokerServiceExternalECStreamed {
        
        public BrokerServiceExternalECStreamedClient() {
        }
        
        public BrokerServiceExternalECStreamedClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BrokerServiceExternalECStreamedClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerServiceExternalECStreamedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerServiceExternalECStreamedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestResponse IBrokerServiceExternalECStreamed.Test(TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            TestRequest inValue = new TestRequest();
            TestResponse retVal = ((IBrokerServiceExternalECStreamed)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestResponse> IBrokerServiceExternalECStreamed.TestAsync(TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestResponse> TestAsync() {
            TestRequest inValue = new TestRequest();
            return ((IBrokerServiceExternalECStreamed)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ReceiptExternalStreamedBE IBrokerServiceExternalECStreamed.UploadFileStreamedEC(StreamedPayloadECBE request) {
            return base.Channel.UploadFileStreamedEC(request);
        }
        
        public string UploadFileStreamedEC(string FileName, string Password, string Reference, string Reportee, string UserName, System.IO.Stream DataStream, out int ParentReceiptId, out string ReceiptHistory, out int ReceiptId, out string ReceiptStatusCode, out string ReceiptText, out string ReceiptTypeName) {
            StreamedPayloadECBE inValue = new StreamedPayloadECBE();
            inValue.FileName = FileName;
            inValue.Password = Password;
            inValue.Reference = Reference;
            inValue.Reportee = Reportee;
            inValue.UserName = UserName;
            inValue.DataStream = DataStream;
            ReceiptExternalStreamedBE retVal = ((IBrokerServiceExternalECStreamed)(this)).UploadFileStreamedEC(inValue);
            ParentReceiptId = retVal.ParentReceiptId;
            ReceiptHistory = retVal.ReceiptHistory;
            ReceiptId = retVal.ReceiptId;
            ReceiptStatusCode = retVal.ReceiptStatusCode;
            ReceiptText = retVal.ReceiptText;
            ReceiptTypeName = retVal.ReceiptTypeName;
            return retVal.LastChanged;
        }
        
        public System.Threading.Tasks.Task<ReceiptExternalStreamedBE> UploadFileStreamedECAsync(StreamedPayloadECBE request) {
            return base.Channel.UploadFileStreamedECAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DownloadFileStreamedECResponse IBrokerServiceExternalECStreamed.DownloadFileStreamedEC(DownloadFileStreamedECRequest request) {
            return base.Channel.DownloadFileStreamedEC(request);
        }
        
        public byte[] DownloadFileStreamedEC(string userName, string password, string fileReference, string reportee) {
            DownloadFileStreamedECRequest inValue = new DownloadFileStreamedECRequest();
            inValue.Body = new DownloadFileStreamedECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.fileReference = fileReference;
            inValue.Body.reportee = reportee;
            DownloadFileStreamedECResponse retVal = ((IBrokerServiceExternalECStreamed)(this)).DownloadFileStreamedEC(inValue);
            return retVal.Body.DownloadFileStreamedECResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DownloadFileStreamedECResponse> IBrokerServiceExternalECStreamed.DownloadFileStreamedECAsync(DownloadFileStreamedECRequest request) {
            return base.Channel.DownloadFileStreamedECAsync(request);
        }
        
        public System.Threading.Tasks.Task<DownloadFileStreamedECResponse> DownloadFileStreamedECAsync(string userName, string password, string fileReference, string reportee) {
            DownloadFileStreamedECRequest inValue = new DownloadFileStreamedECRequest();
            inValue.Body = new DownloadFileStreamedECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.fileReference = fileReference;
            inValue.Body.reportee = reportee;
            return ((IBrokerServiceExternalECStreamed)(this)).DownloadFileStreamedECAsync(inValue);
        }
    }
}
