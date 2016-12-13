﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SensatoClient.SensatoServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsernameValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
    [System.SerializableAttribute()]
    public partial class UsernameValidationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PasswordValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
    [System.SerializableAttribute()]
    public partial class PasswordValidationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AlreadyExistFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
    [System.SerializableAttribute()]
    public partial class AlreadyExistFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SensatoServiceReference.ISensatoService")]
    public interface ISensatoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckUserExists", ReplyAction="http://tempuri.org/ISensatoService/CheckUserExistsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.UsernameValidationFault), Action="http://tempuri.org/ISensatoService/CheckUserExistsUsernameValidationFaultFault", Name="UsernameValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        bool CheckUserExists(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckUserExists", ReplyAction="http://tempuri.org/ISensatoService/CheckUserExistsResponse")]
        System.Threading.Tasks.Task<bool> CheckUserExistsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckPassowrdMatch", ReplyAction="http://tempuri.org/ISensatoService/CheckPassowrdMatchResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.PasswordValidationFault), Action="http://tempuri.org/ISensatoService/CheckPassowrdMatchPasswordValidationFaultFault" +
            "", Name="PasswordValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        bool CheckPassowrdMatch(string passwordHash, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckPassowrdMatch", ReplyAction="http://tempuri.org/ISensatoService/CheckPassowrdMatchResponse")]
        System.Threading.Tasks.Task<bool> CheckPassowrdMatchAsync(string passwordHash, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetUserHivesByUsername", ReplyAction="http://tempuri.org/ISensatoService/GetUserHivesByUsernameResponse")]
        string[] GetUserHivesByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetUserHivesByUsername", ReplyAction="http://tempuri.org/ISensatoService/GetUserHivesByUsernameResponse")]
        System.Threading.Tasks.Task<string[]> GetUserHivesByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/AddHive", ReplyAction="http://tempuri.org/ISensatoService/AddHiveResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.AlreadyExistFault), Action="http://tempuri.org/ISensatoService/AddHiveAlreadyExistFaultFault", Name="AlreadyExistFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        void AddHive(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/AddHive", ReplyAction="http://tempuri.org/ISensatoService/AddHiveResponse")]
        System.Threading.Tasks.Task AddHiveAsync(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RenameHive", ReplyAction="http://tempuri.org/ISensatoService/RenameHiveResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.AlreadyExistFault), Action="http://tempuri.org/ISensatoService/RenameHiveAlreadyExistFaultFault", Name="AlreadyExistFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        bool RenameHive(string username, string newHiveName, string currentHiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RenameHive", ReplyAction="http://tempuri.org/ISensatoService/RenameHiveResponse")]
        System.Threading.Tasks.Task<bool> RenameHiveAsync(string username, string newHiveName, string currentHiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RemoveHive", ReplyAction="http://tempuri.org/ISensatoService/RemoveHiveResponse")]
        bool RemoveHive(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RemoveHive", ReplyAction="http://tempuri.org/ISensatoService/RemoveHiveResponse")]
        System.Threading.Tasks.Task<bool> RemoveHiveAsync(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetFramesByHiveName", ReplyAction="http://tempuri.org/ISensatoService/GetFramesByHiveNameResponse")]
        int[] GetFramesByHiveName(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetFramesByHiveName", ReplyAction="http://tempuri.org/ISensatoService/GetFramesByHiveNameResponse")]
        System.Threading.Tasks.Task<int[]> GetFramesByHiveNameAsync(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/ChangeFrameStatusByHiveName", ReplyAction="http://tempuri.org/ISensatoService/ChangeFrameStatusByHiveNameResponse")]
        void ChangeFrameStatusByHiveName(string username, string hivename, int[] activeFramesPositions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/ChangeFrameStatusByHiveName", ReplyAction="http://tempuri.org/ISensatoService/ChangeFrameStatusByHiveNameResponse")]
        System.Threading.Tasks.Task ChangeFrameStatusByHiveNameAsync(string username, string hivename, int[] activeFramesPositions);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISensatoServiceChannel : SensatoClient.SensatoServiceReference.ISensatoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SensatoServiceClient : System.ServiceModel.ClientBase<SensatoClient.SensatoServiceReference.ISensatoService>, SensatoClient.SensatoServiceReference.ISensatoService {
        
        public SensatoServiceClient() {
        }
        
        public SensatoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SensatoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensatoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensatoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckUserExists(string username) {
            return base.Channel.CheckUserExists(username);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserExistsAsync(string username) {
            return base.Channel.CheckUserExistsAsync(username);
        }
        
        public bool CheckPassowrdMatch(string passwordHash, string username) {
            return base.Channel.CheckPassowrdMatch(passwordHash, username);
        }
        
        public System.Threading.Tasks.Task<bool> CheckPassowrdMatchAsync(string passwordHash, string username) {
            return base.Channel.CheckPassowrdMatchAsync(passwordHash, username);
        }
        
        public string[] GetUserHivesByUsername(string username) {
            return base.Channel.GetUserHivesByUsername(username);
        }
        
        public System.Threading.Tasks.Task<string[]> GetUserHivesByUsernameAsync(string username) {
            return base.Channel.GetUserHivesByUsernameAsync(username);
        }
        
        public void AddHive(string username, string hiveName) {
            base.Channel.AddHive(username, hiveName);
        }
        
        public System.Threading.Tasks.Task AddHiveAsync(string username, string hiveName) {
            return base.Channel.AddHiveAsync(username, hiveName);
        }
        
        public bool RenameHive(string username, string newHiveName, string currentHiveName) {
            return base.Channel.RenameHive(username, newHiveName, currentHiveName);
        }
        
        public System.Threading.Tasks.Task<bool> RenameHiveAsync(string username, string newHiveName, string currentHiveName) {
            return base.Channel.RenameHiveAsync(username, newHiveName, currentHiveName);
        }
        
        public bool RemoveHive(string username, string hiveName) {
            return base.Channel.RemoveHive(username, hiveName);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveHiveAsync(string username, string hiveName) {
            return base.Channel.RemoveHiveAsync(username, hiveName);
        }
        
        public int[] GetFramesByHiveName(string username, string hiveName) {
            return base.Channel.GetFramesByHiveName(username, hiveName);
        }
        
        public System.Threading.Tasks.Task<int[]> GetFramesByHiveNameAsync(string username, string hiveName) {
            return base.Channel.GetFramesByHiveNameAsync(username, hiveName);
        }
        
        public void ChangeFrameStatusByHiveName(string username, string hivename, int[] activeFramesPositions) {
            base.Channel.ChangeFrameStatusByHiveName(username, hivename, activeFramesPositions);
        }
        
        public System.Threading.Tasks.Task ChangeFrameStatusByHiveNameAsync(string username, string hivename, int[] activeFramesPositions) {
            return base.Channel.ChangeFrameStatusByHiveNameAsync(username, hivename, activeFramesPositions);
        }
    }
}
