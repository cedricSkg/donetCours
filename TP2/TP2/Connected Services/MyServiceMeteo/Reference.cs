﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP2.MyServiceMeteo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceMeteo.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        TP2.MyServiceMeteo.CompositeType GetDataUsingDataContract(TP2.MyServiceMeteo.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<TP2.MyServiceMeteo.CompositeType> GetDataUsingDataContractAsync(TP2.MyServiceMeteo.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Meteo_GetTemperature", ReplyAction="http://tempuri.org/IService/Meteo_GetTemperatureResponse")]
        string Meteo_GetTemperature();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Meteo_GetTemperature", ReplyAction="http://tempuri.org/IService/Meteo_GetTemperatureResponse")]
        System.Threading.Tasks.Task<string> Meteo_GetTemperatureAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Meteo_GetTemperatureByDate", ReplyAction="http://tempuri.org/IService/Meteo_GetTemperatureByDateResponse")]
        TP2.MyServiceMeteo.Meteo_GetTemperatureByDateResponse Meteo_GetTemperatureByDate(TP2.MyServiceMeteo.Meteo_GetTemperatureByDateRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs de retour.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Meteo_GetTemperatureByDate", ReplyAction="http://tempuri.org/IService/Meteo_GetTemperatureByDateResponse")]
        System.Threading.Tasks.Task<TP2.MyServiceMeteo.Meteo_GetTemperatureByDateResponse> Meteo_GetTemperatureByDateAsync(TP2.MyServiceMeteo.Meteo_GetTemperatureByDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Meteo_GetTemperatureDay", ReplyAction="http://tempuri.org/IService/Meteo_GetTemperatureDayResponse")]
        System.Data.DataSet Meteo_GetTemperatureDay(string dateRecherche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Meteo_GetTemperatureDay", ReplyAction="http://tempuri.org/IService/Meteo_GetTemperatureDayResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> Meteo_GetTemperatureDayAsync(string dateRecherche);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Meteo_GetTemperatureByDate", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Meteo_GetTemperatureByDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string dateRecherche;
        
        public Meteo_GetTemperatureByDateRequest() {
        }
        
        public Meteo_GetTemperatureByDateRequest(string dateRecherche) {
            this.dateRecherche = dateRecherche;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Meteo_GetTemperatureByDateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Meteo_GetTemperatureByDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Meteo_GetTemperatureByDateResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string dateReleve;
        
        public Meteo_GetTemperatureByDateResponse() {
        }
        
        public Meteo_GetTemperatureByDateResponse(string Meteo_GetTemperatureByDateResult, string dateReleve) {
            this.Meteo_GetTemperatureByDateResult = Meteo_GetTemperatureByDateResult;
            this.dateReleve = dateReleve;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : TP2.MyServiceMeteo.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<TP2.MyServiceMeteo.IService>, TP2.MyServiceMeteo.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public TP2.MyServiceMeteo.CompositeType GetDataUsingDataContract(TP2.MyServiceMeteo.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<TP2.MyServiceMeteo.CompositeType> GetDataUsingDataContractAsync(TP2.MyServiceMeteo.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string Meteo_GetTemperature() {
            return base.Channel.Meteo_GetTemperature();
        }
        
        public System.Threading.Tasks.Task<string> Meteo_GetTemperatureAsync() {
            return base.Channel.Meteo_GetTemperatureAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TP2.MyServiceMeteo.Meteo_GetTemperatureByDateResponse TP2.MyServiceMeteo.IService.Meteo_GetTemperatureByDate(TP2.MyServiceMeteo.Meteo_GetTemperatureByDateRequest request) {
            return base.Channel.Meteo_GetTemperatureByDate(request);
        }
        
        public string Meteo_GetTemperatureByDate(string dateRecherche, out string dateReleve) {
            TP2.MyServiceMeteo.Meteo_GetTemperatureByDateRequest inValue = new TP2.MyServiceMeteo.Meteo_GetTemperatureByDateRequest();
            inValue.dateRecherche = dateRecherche;
            TP2.MyServiceMeteo.Meteo_GetTemperatureByDateResponse retVal = ((TP2.MyServiceMeteo.IService)(this)).Meteo_GetTemperatureByDate(inValue);
            dateReleve = retVal.dateReleve;
            return retVal.Meteo_GetTemperatureByDateResult;
        }
        
        public System.Threading.Tasks.Task<TP2.MyServiceMeteo.Meteo_GetTemperatureByDateResponse> Meteo_GetTemperatureByDateAsync(TP2.MyServiceMeteo.Meteo_GetTemperatureByDateRequest request) {
            return base.Channel.Meteo_GetTemperatureByDateAsync(request);
        }
        
        public System.Data.DataSet Meteo_GetTemperatureDay(string dateRecherche) {
            return base.Channel.Meteo_GetTemperatureDay(dateRecherche);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Meteo_GetTemperatureDayAsync(string dateRecherche) {
            return base.Channel.Meteo_GetTemperatureDayAsync(dateRecherche);
        }
    }
}