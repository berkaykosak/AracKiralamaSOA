﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama.SoapServices.AracBilgiService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AracTransfer", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AracTransfer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int aracIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aracMarkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aracModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gerekenEhliyetYasiField;
        
        private System.Nullable<byte> minimumYasField;
        
        private System.Nullable<int> gunlukKmSinirField;
        
        private System.Nullable<long> anlikKmField;
        
        private System.Nullable<bool> airbagField;
        
        private System.Nullable<int> bagajHacmiField;
        
        private System.Nullable<byte> koltukSayisiField;
        
        private System.Nullable<decimal> gunlukKiralikFiyatField;
        
        private System.Nullable<int> sirketIDField;
        
        private System.Nullable<bool> RezerveField;
        
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
        public int aracID {
            get {
                return this.aracIDField;
            }
            set {
                if ((this.aracIDField.Equals(value) != true)) {
                    this.aracIDField = value;
                    this.RaisePropertyChanged("aracID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string aracMarka {
            get {
                return this.aracMarkaField;
            }
            set {
                if ((object.ReferenceEquals(this.aracMarkaField, value) != true)) {
                    this.aracMarkaField = value;
                    this.RaisePropertyChanged("aracMarka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string aracModel {
            get {
                return this.aracModelField;
            }
            set {
                if ((object.ReferenceEquals(this.aracModelField, value) != true)) {
                    this.aracModelField = value;
                    this.RaisePropertyChanged("aracModel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string gerekenEhliyetYasi {
            get {
                return this.gerekenEhliyetYasiField;
            }
            set {
                if ((object.ReferenceEquals(this.gerekenEhliyetYasiField, value) != true)) {
                    this.gerekenEhliyetYasiField = value;
                    this.RaisePropertyChanged("gerekenEhliyetYasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<byte> minimumYas {
            get {
                return this.minimumYasField;
            }
            set {
                if ((this.minimumYasField.Equals(value) != true)) {
                    this.minimumYasField = value;
                    this.RaisePropertyChanged("minimumYas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<int> gunlukKmSinir {
            get {
                return this.gunlukKmSinirField;
            }
            set {
                if ((this.gunlukKmSinirField.Equals(value) != true)) {
                    this.gunlukKmSinirField = value;
                    this.RaisePropertyChanged("gunlukKmSinir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<long> anlikKm {
            get {
                return this.anlikKmField;
            }
            set {
                if ((this.anlikKmField.Equals(value) != true)) {
                    this.anlikKmField = value;
                    this.RaisePropertyChanged("anlikKm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<bool> airbag {
            get {
                return this.airbagField;
            }
            set {
                if ((this.airbagField.Equals(value) != true)) {
                    this.airbagField = value;
                    this.RaisePropertyChanged("airbag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<int> bagajHacmi {
            get {
                return this.bagajHacmiField;
            }
            set {
                if ((this.bagajHacmiField.Equals(value) != true)) {
                    this.bagajHacmiField = value;
                    this.RaisePropertyChanged("bagajHacmi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public System.Nullable<byte> koltukSayisi {
            get {
                return this.koltukSayisiField;
            }
            set {
                if ((this.koltukSayisiField.Equals(value) != true)) {
                    this.koltukSayisiField = value;
                    this.RaisePropertyChanged("koltukSayisi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public System.Nullable<decimal> gunlukKiralikFiyat {
            get {
                return this.gunlukKiralikFiyatField;
            }
            set {
                if ((this.gunlukKiralikFiyatField.Equals(value) != true)) {
                    this.gunlukKiralikFiyatField = value;
                    this.RaisePropertyChanged("gunlukKiralikFiyat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public System.Nullable<int> sirketID {
            get {
                return this.sirketIDField;
            }
            set {
                if ((this.sirketIDField.Equals(value) != true)) {
                    this.sirketIDField = value;
                    this.RaisePropertyChanged("sirketID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
        public System.Nullable<bool> Rezerve {
            get {
                return this.RezerveField;
            }
            set {
                if ((this.RezerveField.Equals(value) != true)) {
                    this.RezerveField = value;
                    this.RaisePropertyChanged("Rezerve");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AracBilgiService.AracBilgiSoapServiceSoap")]
    public interface AracBilgiSoapServiceSoap {
        
        // CODEGEN: http://tempuri.org/ ad alanındaki nesne öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        AracKiralama.SoapServices.AracBilgiService.AddResponse Add(AracKiralama.SoapServices.AracBilgiService.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.AddResponse> AddAsync(AracKiralama.SoapServices.AracBilgiService.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
        
        // CODEGEN: http://tempuri.org/ ad alanındaki GetResult öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        AracKiralama.SoapServices.AracBilgiService.GetResponse Get(AracKiralama.SoapServices.AracBilgiService.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.GetResponse> GetAsync(AracKiralama.SoapServices.AracBilgiService.GetRequest request);
        
        // CODEGEN: http://tempuri.org/ ad alanındaki GetAllResult öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        AracKiralama.SoapServices.AracBilgiService.GetAllResponse GetAll(AracKiralama.SoapServices.AracBilgiService.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.GetAllResponse> GetAllAsync(AracKiralama.SoapServices.AracBilgiService.GetAllRequest request);
        
        // CODEGEN: http://tempuri.org/ ad alanındaki nesne3 öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        AracKiralama.SoapServices.AracBilgiService.UpdateResponse Update(AracKiralama.SoapServices.AracBilgiService.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.UpdateResponse> UpdateAsync(AracKiralama.SoapServices.AracBilgiService.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(AracKiralama.SoapServices.AracBilgiService.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne) {
            this.nesne = nesne;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(AracKiralama.SoapServices.AracBilgiService.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddResponseBody {
        
        public AddResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(AracKiralama.SoapServices.AracBilgiService.GetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetRequestBody() {
        }
        
        public GetRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(AracKiralama.SoapServices.AracBilgiService.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.AracTransfer GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(AracKiralama.SoapServices.AracBilgiService.AracTransfer GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(AracKiralama.SoapServices.AracBilgiService.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(AracKiralama.SoapServices.AracBilgiService.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.AracTransfer[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(AracKiralama.SoapServices.AracBilgiService.AracTransfer[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(AracKiralama.SoapServices.AracBilgiService.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne3;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne3) {
            this.nesne3 = nesne3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.SoapServices.AracBilgiService.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(AracKiralama.SoapServices.AracBilgiService.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateResponseBody {
        
        public UpdateResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AracBilgiSoapServiceSoapChannel : AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AracBilgiSoapServiceSoapClient : System.ServiceModel.ClientBase<AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap>, AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap {
        
        public AracBilgiSoapServiceSoapClient() {
        }
        
        public AracBilgiSoapServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AracBilgiSoapServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AracBilgiSoapServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AracBilgiSoapServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.SoapServices.AracBilgiService.AddResponse AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.Add(AracKiralama.SoapServices.AracBilgiService.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public void Add(AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne) {
            AracKiralama.SoapServices.AracBilgiService.AddRequest inValue = new AracKiralama.SoapServices.AracBilgiService.AddRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.AddRequestBody();
            inValue.Body.nesne = nesne;
            AracKiralama.SoapServices.AracBilgiService.AddResponse retVal = ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).Add(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.AddResponse> AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.AddAsync(AracKiralama.SoapServices.AracBilgiService.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.AddResponse> AddAsync(AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne) {
            AracKiralama.SoapServices.AracBilgiService.AddRequest inValue = new AracKiralama.SoapServices.AracBilgiService.AddRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.AddRequestBody();
            inValue.Body.nesne = nesne;
            return ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).AddAsync(inValue);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.SoapServices.AracBilgiService.GetResponse AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.Get(AracKiralama.SoapServices.AracBilgiService.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public AracKiralama.SoapServices.AracBilgiService.AracTransfer Get(int id) {
            AracKiralama.SoapServices.AracBilgiService.GetRequest inValue = new AracKiralama.SoapServices.AracBilgiService.GetRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.GetRequestBody();
            inValue.Body.id = id;
            AracKiralama.SoapServices.AracBilgiService.GetResponse retVal = ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.GetResponse> AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.GetAsync(AracKiralama.SoapServices.AracBilgiService.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.GetResponse> GetAsync(int id) {
            AracKiralama.SoapServices.AracBilgiService.GetRequest inValue = new AracKiralama.SoapServices.AracBilgiService.GetRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.GetRequestBody();
            inValue.Body.id = id;
            return ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.SoapServices.AracBilgiService.GetAllResponse AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.GetAll(AracKiralama.SoapServices.AracBilgiService.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public AracKiralama.SoapServices.AracBilgiService.AracTransfer[] GetAll() {
            AracKiralama.SoapServices.AracBilgiService.GetAllRequest inValue = new AracKiralama.SoapServices.AracBilgiService.GetAllRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.GetAllRequestBody();
            AracKiralama.SoapServices.AracBilgiService.GetAllResponse retVal = ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.GetAllResponse> AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.GetAllAsync(AracKiralama.SoapServices.AracBilgiService.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.GetAllResponse> GetAllAsync() {
            AracKiralama.SoapServices.AracBilgiService.GetAllRequest inValue = new AracKiralama.SoapServices.AracBilgiService.GetAllRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.GetAllRequestBody();
            return ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.SoapServices.AracBilgiService.UpdateResponse AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.Update(AracKiralama.SoapServices.AracBilgiService.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public void Update(AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne3) {
            AracKiralama.SoapServices.AracBilgiService.UpdateRequest inValue = new AracKiralama.SoapServices.AracBilgiService.UpdateRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.UpdateRequestBody();
            inValue.Body.nesne3 = nesne3;
            AracKiralama.SoapServices.AracBilgiService.UpdateResponse retVal = ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).Update(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.UpdateResponse> AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap.UpdateAsync(AracKiralama.SoapServices.AracBilgiService.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.SoapServices.AracBilgiService.UpdateResponse> UpdateAsync(AracKiralama.SoapServices.AracBilgiService.AracTransfer nesne3) {
            AracKiralama.SoapServices.AracBilgiService.UpdateRequest inValue = new AracKiralama.SoapServices.AracBilgiService.UpdateRequest();
            inValue.Body = new AracKiralama.SoapServices.AracBilgiService.UpdateRequestBody();
            inValue.Body.nesne3 = nesne3;
            return ((AracKiralama.SoapServices.AracBilgiService.AracBilgiSoapServiceSoap)(this)).UpdateAsync(inValue);
        }
    }
}