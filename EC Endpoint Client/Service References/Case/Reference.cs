﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace EC_Endpoint_Client.Service_References.Case {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [CollectionDataContract(Name="CaseBEList", Namespace="http://schemas.altinn.no/services/ServiceEngine/Case/2010/10", ItemName="CaseBE")]
    [Serializable()]
    public class CaseBEList : System.Collections.Generic.List<CaseBE> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name="CaseBE", Namespace="http://schemas.altinn.no/services/ServiceEngine/Case/2010/10")]
    [Serializable()]
    public partial class CaseBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [NonSerialized()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [OptionalField()]
        private int CaseIDField;
        
        [OptionalField()]
        private string CaseNameField;
        
        [OptionalField()]
        private string CommentsField;
        
        [OptionalField()]
        private string CurrentStateFriendlyNameField;
        
        [OptionalField()]
        private int CurrentStateIDField;
        
        [OptionalField()]
        private string CurrentStateNameField;
        
        [OptionalField()]
        private System.Nullable<System.DateTime> DueDateField;
        
        [OptionalField()]
        private string NoticeField;
        
        [OptionalField()]
        private string NoticeTemplateIDField;
        
        [OptionalField()]
        private System.Nullable<System.DateTime> VisibleDateTimeField;
        
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
        public int CaseID {
            get {
                return this.CaseIDField;
            }
            set {
                if ((this.CaseIDField.Equals(value) != true)) {
                    this.CaseIDField = value;
                    this.RaisePropertyChanged("CaseID");
                }
            }
        }
        
        [DataMember()]
        public string CaseName {
            get {
                return this.CaseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CaseNameField, value) != true)) {
                    this.CaseNameField = value;
                    this.RaisePropertyChanged("CaseName");
                }
            }
        }
        
        [DataMember()]
        public string Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [DataMember()]
        public string CurrentStateFriendlyName {
            get {
                return this.CurrentStateFriendlyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentStateFriendlyNameField, value) != true)) {
                    this.CurrentStateFriendlyNameField = value;
                    this.RaisePropertyChanged("CurrentStateFriendlyName");
                }
            }
        }
        
        [DataMember()]
        public int CurrentStateID {
            get {
                return this.CurrentStateIDField;
            }
            set {
                if ((this.CurrentStateIDField.Equals(value) != true)) {
                    this.CurrentStateIDField = value;
                    this.RaisePropertyChanged("CurrentStateID");
                }
            }
        }
        
        [DataMember()]
        public string CurrentStateName {
            get {
                return this.CurrentStateNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentStateNameField, value) != true)) {
                    this.CurrentStateNameField = value;
                    this.RaisePropertyChanged("CurrentStateName");
                }
            }
        }
        
        [DataMember(EmitDefaultValue=false)]
        public System.Nullable<System.DateTime> DueDate {
            get {
                return this.DueDateField;
            }
            set {
                if ((this.DueDateField.Equals(value) != true)) {
                    this.DueDateField = value;
                    this.RaisePropertyChanged("DueDate");
                }
            }
        }
        
        [DataMember()]
        public string Notice {
            get {
                return this.NoticeField;
            }
            set {
                if ((object.ReferenceEquals(this.NoticeField, value) != true)) {
                    this.NoticeField = value;
                    this.RaisePropertyChanged("Notice");
                }
            }
        }
        
        [DataMember()]
        public string NoticeTemplateID {
            get {
                return this.NoticeTemplateIDField;
            }
            set {
                if ((object.ReferenceEquals(this.NoticeTemplateIDField, value) != true)) {
                    this.NoticeTemplateIDField = value;
                    this.RaisePropertyChanged("NoticeTemplateID");
                }
            }
        }
        
        [DataMember(EmitDefaultValue=false)]
        public System.Nullable<System.DateTime> VisibleDateTime {
            get {
                return this.VisibleDateTimeField;
            }
            set {
                if ((this.VisibleDateTimeField.Equals(value) != true)) {
                    this.VisibleDateTimeField = value;
                    this.RaisePropertyChanged("VisibleDateTime");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10", ConfigurationName="Case.ICaseEC")]
    public interface ICaseEC {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/ServiceEngine/Case/2010/10)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        TestResponse Test(TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<TestResponse> TestAsync(TestRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/ServiceEngine/Case/2010/10 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/ArchiveCaseEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/ArchiveCaseECRes" +
            "ponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/ArchiveCaseECAlt" +
            "innFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        ArchiveCaseECResponse ArchiveCaseEC(ArchiveCaseECRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/ArchiveCaseEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/ArchiveCaseECRes" +
            "ponse")]
        System.Threading.Tasks.Task<ArchiveCaseECResponse> ArchiveCaseECAsync(ArchiveCaseECRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/ServiceEngine/Case/2010/10 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/GetCaseListEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/GetCaseListECRes" +
            "ponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/GetCaseListECAlt" +
            "innFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        GetCaseListECResponse GetCaseListEC(GetCaseListECRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/GetCaseListEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/GetCaseListECRes" +
            "ponse")]
        System.Threading.Tasks.Task<GetCaseListECResponse> GetCaseListECAsync(GetCaseListECRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/ServiceEngine/Case/2010/10 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/InstantiateColla" +
            "borationEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/InstantiateColla" +
            "borationECResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/InstantiateColla" +
            "borationECAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        InstantiateCollaborationECResponse InstantiateCollaborationEC(InstantiateCollaborationECRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/InstantiateColla" +
            "borationEC", ReplyAction="http://www.altinn.no/services/ServiceEngine/Case/2010/10/ICaseEC/InstantiateColla" +
            "borationECResponse")]
        System.Threading.Tasks.Task<InstantiateCollaborationECResponse> InstantiateCollaborationECAsync(InstantiateCollaborationECRequest request);
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ArchiveCaseECRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ArchiveCaseEC", Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10", Order=0)]
        public ArchiveCaseECRequestBody Body;
        
        public ArchiveCaseECRequest() {
        }
        
        public ArchiveCaseECRequest(ArchiveCaseECRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10")]
    public partial class ArchiveCaseECRequestBody {
        
        [DataMember(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [DataMember(EmitDefaultValue=false, Order=1)]
        public string userPassword;
        
        [DataMember(Order=2)]
        public int caseID;
        
        [DataMember(Order=3)]
        public bool forceArchive;
        
        public ArchiveCaseECRequestBody() {
        }
        
        public ArchiveCaseECRequestBody(string userName, string userPassword, int caseID, bool forceArchive) {
            this.userName = userName;
            this.userPassword = userPassword;
            this.caseID = caseID;
            this.forceArchive = forceArchive;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ArchiveCaseECResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ArchiveCaseECResponse", Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10", Order=0)]
        public ArchiveCaseECResponseBody Body;
        
        public ArchiveCaseECResponse() {
        }
        
        public ArchiveCaseECResponse(ArchiveCaseECResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10")]
    public partial class ArchiveCaseECResponseBody {
        
        [DataMember(Order=0)]
        public int ArchiveCaseECResult;
        
        public ArchiveCaseECResponseBody() {
        }
        
        public ArchiveCaseECResponseBody(int ArchiveCaseECResult) {
            this.ArchiveCaseECResult = ArchiveCaseECResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCaseListECRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCaseListEC", Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10", Order=0)]
        public GetCaseListECRequestBody Body;
        
        public GetCaseListECRequest() {
        }
        
        public GetCaseListECRequest(GetCaseListECRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10")]
    public partial class GetCaseListECRequestBody {
        
        [DataMember(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [DataMember(EmitDefaultValue=false, Order=1)]
        public string userPassword;
        
        [DataMember(Order=2)]
        public int caseID;
        
        [DataMember(Order=3)]
        public string externalServiceCode;
        
        [DataMember(Order=4)]
        public int externalServiceEditionCode;
        
        [DataMember(Order=5)]
        public int languageID;
        
        [DataMember(EmitDefaultValue=false, Order=6)]
        public string reporteeNumber;
        
        public GetCaseListECRequestBody() {
        }
        
        public GetCaseListECRequestBody(string userName, string userPassword, int caseID, string externalServiceCode, int externalServiceEditionCode, int languageID, string reporteeNumber) {
            this.userName = userName;
            this.userPassword = userPassword;
            this.caseID = caseID;
            this.externalServiceCode = externalServiceCode;
            this.externalServiceEditionCode = externalServiceEditionCode;
            this.languageID = languageID;
            this.reporteeNumber = reporteeNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCaseListECResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCaseListECResponse", Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10", Order=0)]
        public GetCaseListECResponseBody Body;
        
        public GetCaseListECResponse() {
        }
        
        public GetCaseListECResponse(GetCaseListECResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10")]
    public partial class GetCaseListECResponseBody {
        
        [DataMember(Order=0)]
        public CaseBEList GetCaseListECResult;
        
        public GetCaseListECResponseBody() {
        }
        
        public GetCaseListECResponseBody(CaseBEList GetCaseListECResult) {
            this.GetCaseListECResult = GetCaseListECResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InstantiateCollaborationECRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InstantiateCollaborationEC", Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10", Order=0)]
        public InstantiateCollaborationECRequestBody Body;
        
        public InstantiateCollaborationECRequest() {
        }
        
        public InstantiateCollaborationECRequest(InstantiateCollaborationECRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10")]
    public partial class InstantiateCollaborationECRequestBody {
        
        [DataMember(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [DataMember(EmitDefaultValue=false, Order=1)]
        public string userPassword;
        
        [DataMember(EmitDefaultValue=false, Order=2)]
        public string externalServiceCode;
        
        [DataMember(Order=3)]
        public int externalServiceEditionCode;
        
        [DataMember(EmitDefaultValue=false, Order=4)]
        public string reporteeNumber;
        
        [DataMember(Order=5)]
        public string externalSystemReference;
        
        [DataMember(Order=6)]
        public System.DateTime visibleDateTime;
        
        [DataMember(Order=7)]
        public System.DateTime dueDate;
        
        public InstantiateCollaborationECRequestBody() {
        }
        
        public InstantiateCollaborationECRequestBody(string userName, string userPassword, string externalServiceCode, int externalServiceEditionCode, string reporteeNumber, string externalSystemReference, System.DateTime visibleDateTime, System.DateTime dueDate) {
            this.userName = userName;
            this.userPassword = userPassword;
            this.externalServiceCode = externalServiceCode;
            this.externalServiceEditionCode = externalServiceEditionCode;
            this.reporteeNumber = reporteeNumber;
            this.externalSystemReference = externalSystemReference;
            this.visibleDateTime = visibleDateTime;
            this.dueDate = dueDate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InstantiateCollaborationECResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InstantiateCollaborationECResponse", Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10", Order=0)]
        public InstantiateCollaborationECResponseBody Body;
        
        public InstantiateCollaborationECResponse() {
        }
        
        public InstantiateCollaborationECResponse(InstantiateCollaborationECResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/Case/2010/10")]
    public partial class InstantiateCollaborationECResponseBody {
        
        [DataMember(Order=0)]
        public int InstantiateCollaborationECResult;
        
        public InstantiateCollaborationECResponseBody() {
        }
        
        public InstantiateCollaborationECResponseBody(int InstantiateCollaborationECResult) {
            this.InstantiateCollaborationECResult = InstantiateCollaborationECResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICaseECChannel : ICaseEC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaseECClient : System.ServiceModel.ClientBase<ICaseEC>, ICaseEC {
        
        public CaseECClient() {
        }
        
        public CaseECClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CaseECClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaseECClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaseECClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestResponse ICaseEC.Test(TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            TestRequest inValue = new TestRequest();
            TestResponse retVal = ((ICaseEC)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestResponse> ICaseEC.TestAsync(TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestResponse> TestAsync() {
            TestRequest inValue = new TestRequest();
            return ((ICaseEC)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArchiveCaseECResponse ICaseEC.ArchiveCaseEC(ArchiveCaseECRequest request) {
            return base.Channel.ArchiveCaseEC(request);
        }
        
        public int ArchiveCaseEC(string userName, string userPassword, int caseID, bool forceArchive) {
            ArchiveCaseECRequest inValue = new ArchiveCaseECRequest();
            inValue.Body = new ArchiveCaseECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.userPassword = userPassword;
            inValue.Body.caseID = caseID;
            inValue.Body.forceArchive = forceArchive;
            ArchiveCaseECResponse retVal = ((ICaseEC)(this)).ArchiveCaseEC(inValue);
            return retVal.Body.ArchiveCaseECResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ArchiveCaseECResponse> ICaseEC.ArchiveCaseECAsync(ArchiveCaseECRequest request) {
            return base.Channel.ArchiveCaseECAsync(request);
        }
        
        public System.Threading.Tasks.Task<ArchiveCaseECResponse> ArchiveCaseECAsync(string userName, string userPassword, int caseID, bool forceArchive) {
            ArchiveCaseECRequest inValue = new ArchiveCaseECRequest();
            inValue.Body = new ArchiveCaseECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.userPassword = userPassword;
            inValue.Body.caseID = caseID;
            inValue.Body.forceArchive = forceArchive;
            return ((ICaseEC)(this)).ArchiveCaseECAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetCaseListECResponse ICaseEC.GetCaseListEC(GetCaseListECRequest request) {
            return base.Channel.GetCaseListEC(request);
        }
        
        public CaseBEList GetCaseListEC(string userName, string userPassword, int caseID, string externalServiceCode, int externalServiceEditionCode, int languageID, string reporteeNumber) {
            GetCaseListECRequest inValue = new GetCaseListECRequest();
            inValue.Body = new GetCaseListECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.userPassword = userPassword;
            inValue.Body.caseID = caseID;
            inValue.Body.externalServiceCode = externalServiceCode;
            inValue.Body.externalServiceEditionCode = externalServiceEditionCode;
            inValue.Body.languageID = languageID;
            inValue.Body.reporteeNumber = reporteeNumber;
            GetCaseListECResponse retVal = ((ICaseEC)(this)).GetCaseListEC(inValue);
            return retVal.Body.GetCaseListECResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetCaseListECResponse> ICaseEC.GetCaseListECAsync(GetCaseListECRequest request) {
            return base.Channel.GetCaseListECAsync(request);
        }
        
        public System.Threading.Tasks.Task<GetCaseListECResponse> GetCaseListECAsync(string userName, string userPassword, int caseID, string externalServiceCode, int externalServiceEditionCode, int languageID, string reporteeNumber) {
            GetCaseListECRequest inValue = new GetCaseListECRequest();
            inValue.Body = new GetCaseListECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.userPassword = userPassword;
            inValue.Body.caseID = caseID;
            inValue.Body.externalServiceCode = externalServiceCode;
            inValue.Body.externalServiceEditionCode = externalServiceEditionCode;
            inValue.Body.languageID = languageID;
            inValue.Body.reporteeNumber = reporteeNumber;
            return ((ICaseEC)(this)).GetCaseListECAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InstantiateCollaborationECResponse ICaseEC.InstantiateCollaborationEC(InstantiateCollaborationECRequest request) {
            return base.Channel.InstantiateCollaborationEC(request);
        }
        
        public int InstantiateCollaborationEC(string userName, string userPassword, string externalServiceCode, int externalServiceEditionCode, string reporteeNumber, string externalSystemReference, System.DateTime visibleDateTime, System.DateTime dueDate) {
            InstantiateCollaborationECRequest inValue = new InstantiateCollaborationECRequest();
            inValue.Body = new InstantiateCollaborationECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.userPassword = userPassword;
            inValue.Body.externalServiceCode = externalServiceCode;
            inValue.Body.externalServiceEditionCode = externalServiceEditionCode;
            inValue.Body.reporteeNumber = reporteeNumber;
            inValue.Body.externalSystemReference = externalSystemReference;
            inValue.Body.visibleDateTime = visibleDateTime;
            inValue.Body.dueDate = dueDate;
            InstantiateCollaborationECResponse retVal = ((ICaseEC)(this)).InstantiateCollaborationEC(inValue);
            return retVal.Body.InstantiateCollaborationECResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InstantiateCollaborationECResponse> ICaseEC.InstantiateCollaborationECAsync(InstantiateCollaborationECRequest request) {
            return base.Channel.InstantiateCollaborationECAsync(request);
        }
        
        public System.Threading.Tasks.Task<InstantiateCollaborationECResponse> InstantiateCollaborationECAsync(string userName, string userPassword, string externalServiceCode, int externalServiceEditionCode, string reporteeNumber, string externalSystemReference, System.DateTime visibleDateTime, System.DateTime dueDate) {
            InstantiateCollaborationECRequest inValue = new InstantiateCollaborationECRequest();
            inValue.Body = new InstantiateCollaborationECRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.userPassword = userPassword;
            inValue.Body.externalServiceCode = externalServiceCode;
            inValue.Body.externalServiceEditionCode = externalServiceEditionCode;
            inValue.Body.reporteeNumber = reporteeNumber;
            inValue.Body.externalSystemReference = externalSystemReference;
            inValue.Body.visibleDateTime = visibleDateTime;
            inValue.Body.dueDate = dueDate;
            return ((ICaseEC)(this)).InstantiateCollaborationECAsync(inValue);
        }
    }
}
