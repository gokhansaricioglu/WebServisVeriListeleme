﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServisVeriListeleme.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Veriler", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Veriler : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoyadField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad {
            get {
                return this.AdField;
            }
            set {
                if ((object.ReferenceEquals(this.AdField, value) != true)) {
                    this.AdField = value;
                    this.RaisePropertyChanged("Ad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad {
            get {
                return this.SoyadField;
            }
            set {
                if ((object.ReferenceEquals(this.SoyadField, value) != true)) {
                    this.SoyadField = value;
                    this.RaisePropertyChanged("Soyad");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: http://tempuri.org/ ad alanındaki ad öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VeriListele", ReplyAction="*")]
        WebServisVeriListeleme.ServiceReference1.VeriListeleResponse VeriListele(WebServisVeriListeleme.ServiceReference1.VeriListeleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VeriListele", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriListeleResponse> VeriListeleAsync(WebServisVeriListeleme.ServiceReference1.VeriListeleRequest request);
        
        // CODEGEN: http://tempuri.org/ ad alanındaki ad öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VeriEkle", ReplyAction="*")]
        WebServisVeriListeleme.ServiceReference1.VeriEkleResponse VeriEkle(WebServisVeriListeleme.ServiceReference1.VeriEkleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VeriEkle", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriEkleResponse> VeriEkleAsync(WebServisVeriListeleme.ServiceReference1.VeriEkleRequest request);
        
        // CODEGEN: http://tempuri.org/ ad alanındaki ad öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VeriSil", ReplyAction="*")]
        WebServisVeriListeleme.ServiceReference1.VeriSilResponse VeriSil(WebServisVeriListeleme.ServiceReference1.VeriSilRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VeriSil", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriSilResponse> VeriSilAsync(WebServisVeriListeleme.ServiceReference1.VeriSilRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeriListeleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeriListele", Namespace="http://tempuri.org/", Order=0)]
        public WebServisVeriListeleme.ServiceReference1.VeriListeleRequestBody Body;
        
        public VeriListeleRequest() {
        }
        
        public VeriListeleRequest(WebServisVeriListeleme.ServiceReference1.VeriListeleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VeriListeleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ad;
        
        public VeriListeleRequestBody() {
        }
        
        public VeriListeleRequestBody(string ad) {
            this.ad = ad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeriListeleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeriListeleResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServisVeriListeleme.ServiceReference1.VeriListeleResponseBody Body;
        
        public VeriListeleResponse() {
        }
        
        public VeriListeleResponse(WebServisVeriListeleme.ServiceReference1.VeriListeleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VeriListeleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServisVeriListeleme.ServiceReference1.Veriler[] VeriListeleResult;
        
        public VeriListeleResponseBody() {
        }
        
        public VeriListeleResponseBody(WebServisVeriListeleme.ServiceReference1.Veriler[] VeriListeleResult) {
            this.VeriListeleResult = VeriListeleResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeriEkleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeriEkle", Namespace="http://tempuri.org/", Order=0)]
        public WebServisVeriListeleme.ServiceReference1.VeriEkleRequestBody Body;
        
        public VeriEkleRequest() {
        }
        
        public VeriEkleRequest(WebServisVeriListeleme.ServiceReference1.VeriEkleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VeriEkleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string soyad;
        
        public VeriEkleRequestBody() {
        }
        
        public VeriEkleRequestBody(string ad, string soyad) {
            this.ad = ad;
            this.soyad = soyad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeriEkleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeriEkleResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServisVeriListeleme.ServiceReference1.VeriEkleResponseBody Body;
        
        public VeriEkleResponse() {
        }
        
        public VeriEkleResponse(WebServisVeriListeleme.ServiceReference1.VeriEkleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class VeriEkleResponseBody {
        
        public VeriEkleResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeriSilRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeriSil", Namespace="http://tempuri.org/", Order=0)]
        public WebServisVeriListeleme.ServiceReference1.VeriSilRequestBody Body;
        
        public VeriSilRequest() {
        }
        
        public VeriSilRequest(WebServisVeriListeleme.ServiceReference1.VeriSilRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VeriSilRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ad;
        
        public VeriSilRequestBody() {
        }
        
        public VeriSilRequestBody(string ad) {
            this.ad = ad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeriSilResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeriSilResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServisVeriListeleme.ServiceReference1.VeriSilResponseBody Body;
        
        public VeriSilResponse() {
        }
        
        public VeriSilResponse(WebServisVeriListeleme.ServiceReference1.VeriSilResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class VeriSilResponseBody {
        
        public VeriSilResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebServisVeriListeleme.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebServisVeriListeleme.ServiceReference1.WebService1Soap>, WebServisVeriListeleme.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServisVeriListeleme.ServiceReference1.VeriListeleResponse WebServisVeriListeleme.ServiceReference1.WebService1Soap.VeriListele(WebServisVeriListeleme.ServiceReference1.VeriListeleRequest request) {
            return base.Channel.VeriListele(request);
        }
        
        public WebServisVeriListeleme.ServiceReference1.Veriler[] VeriListele(string ad) {
            WebServisVeriListeleme.ServiceReference1.VeriListeleRequest inValue = new WebServisVeriListeleme.ServiceReference1.VeriListeleRequest();
            inValue.Body = new WebServisVeriListeleme.ServiceReference1.VeriListeleRequestBody();
            inValue.Body.ad = ad;
            WebServisVeriListeleme.ServiceReference1.VeriListeleResponse retVal = ((WebServisVeriListeleme.ServiceReference1.WebService1Soap)(this)).VeriListele(inValue);
            return retVal.Body.VeriListeleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriListeleResponse> WebServisVeriListeleme.ServiceReference1.WebService1Soap.VeriListeleAsync(WebServisVeriListeleme.ServiceReference1.VeriListeleRequest request) {
            return base.Channel.VeriListeleAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriListeleResponse> VeriListeleAsync(string ad) {
            WebServisVeriListeleme.ServiceReference1.VeriListeleRequest inValue = new WebServisVeriListeleme.ServiceReference1.VeriListeleRequest();
            inValue.Body = new WebServisVeriListeleme.ServiceReference1.VeriListeleRequestBody();
            inValue.Body.ad = ad;
            return ((WebServisVeriListeleme.ServiceReference1.WebService1Soap)(this)).VeriListeleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServisVeriListeleme.ServiceReference1.VeriEkleResponse WebServisVeriListeleme.ServiceReference1.WebService1Soap.VeriEkle(WebServisVeriListeleme.ServiceReference1.VeriEkleRequest request) {
            return base.Channel.VeriEkle(request);
        }
        
        public void VeriEkle(string ad, string soyad) {
            WebServisVeriListeleme.ServiceReference1.VeriEkleRequest inValue = new WebServisVeriListeleme.ServiceReference1.VeriEkleRequest();
            inValue.Body = new WebServisVeriListeleme.ServiceReference1.VeriEkleRequestBody();
            inValue.Body.ad = ad;
            inValue.Body.soyad = soyad;
            WebServisVeriListeleme.ServiceReference1.VeriEkleResponse retVal = ((WebServisVeriListeleme.ServiceReference1.WebService1Soap)(this)).VeriEkle(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriEkleResponse> WebServisVeriListeleme.ServiceReference1.WebService1Soap.VeriEkleAsync(WebServisVeriListeleme.ServiceReference1.VeriEkleRequest request) {
            return base.Channel.VeriEkleAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriEkleResponse> VeriEkleAsync(string ad, string soyad) {
            WebServisVeriListeleme.ServiceReference1.VeriEkleRequest inValue = new WebServisVeriListeleme.ServiceReference1.VeriEkleRequest();
            inValue.Body = new WebServisVeriListeleme.ServiceReference1.VeriEkleRequestBody();
            inValue.Body.ad = ad;
            inValue.Body.soyad = soyad;
            return ((WebServisVeriListeleme.ServiceReference1.WebService1Soap)(this)).VeriEkleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServisVeriListeleme.ServiceReference1.VeriSilResponse WebServisVeriListeleme.ServiceReference1.WebService1Soap.VeriSil(WebServisVeriListeleme.ServiceReference1.VeriSilRequest request) {
            return base.Channel.VeriSil(request);
        }
        
        public void VeriSil(string ad) {
            WebServisVeriListeleme.ServiceReference1.VeriSilRequest inValue = new WebServisVeriListeleme.ServiceReference1.VeriSilRequest();
            inValue.Body = new WebServisVeriListeleme.ServiceReference1.VeriSilRequestBody();
            inValue.Body.ad = ad;
            WebServisVeriListeleme.ServiceReference1.VeriSilResponse retVal = ((WebServisVeriListeleme.ServiceReference1.WebService1Soap)(this)).VeriSil(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriSilResponse> WebServisVeriListeleme.ServiceReference1.WebService1Soap.VeriSilAsync(WebServisVeriListeleme.ServiceReference1.VeriSilRequest request) {
            return base.Channel.VeriSilAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServisVeriListeleme.ServiceReference1.VeriSilResponse> VeriSilAsync(string ad) {
            WebServisVeriListeleme.ServiceReference1.VeriSilRequest inValue = new WebServisVeriListeleme.ServiceReference1.VeriSilRequest();
            inValue.Body = new WebServisVeriListeleme.ServiceReference1.VeriSilRequestBody();
            inValue.Body.ad = ad;
            return ((WebServisVeriListeleme.ServiceReference1.WebService1Soap)(this)).VeriSilAsync(inValue);
        }
    }
}
