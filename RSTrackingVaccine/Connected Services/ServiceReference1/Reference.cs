﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSTrackingVaccine.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="pelaporan_penggunaan", Namespace="http://schemas.datacontract.org/2004/07/WcfRumahSakit")]
    [System.SerializableAttribute()]
    public partial class pelaporan_penggunaan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idBPOMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idPelaporanPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idRSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nikPasienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noRegVaksinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noRekamMedisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusVField;
        
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
        public string idBPOM {
            get {
                return this.idBPOMField;
            }
            set {
                if ((object.ReferenceEquals(this.idBPOMField, value) != true)) {
                    this.idBPOMField = value;
                    this.RaisePropertyChanged("idBPOM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idPelaporanP {
            get {
                return this.idPelaporanPField;
            }
            set {
                if ((object.ReferenceEquals(this.idPelaporanPField, value) != true)) {
                    this.idPelaporanPField = value;
                    this.RaisePropertyChanged("idPelaporanP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idRS {
            get {
                return this.idRSField;
            }
            set {
                if ((object.ReferenceEquals(this.idRSField, value) != true)) {
                    this.idRSField = value;
                    this.RaisePropertyChanged("idRS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nikPasien {
            get {
                return this.nikPasienField;
            }
            set {
                if ((object.ReferenceEquals(this.nikPasienField, value) != true)) {
                    this.nikPasienField = value;
                    this.RaisePropertyChanged("nikPasien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noRegVaksin {
            get {
                return this.noRegVaksinField;
            }
            set {
                if ((object.ReferenceEquals(this.noRegVaksinField, value) != true)) {
                    this.noRegVaksinField = value;
                    this.RaisePropertyChanged("noRegVaksin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noRekamMedis {
            get {
                return this.noRekamMedisField;
            }
            set {
                if ((object.ReferenceEquals(this.noRekamMedisField, value) != true)) {
                    this.noRekamMedisField = value;
                    this.RaisePropertyChanged("noRekamMedis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string statusV {
            get {
                return this.statusVField;
            }
            set {
                if ((object.ReferenceEquals(this.statusVField, value) != true)) {
                    this.statusVField = value;
                    this.RaisePropertyChanged("statusV");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="pasien", Namespace="http://schemas.datacontract.org/2004/07/WcfRumahSakit")]
    [System.SerializableAttribute()]
    public partial class pasien : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string alamatPasienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idPemerintahField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idRSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaPasienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nikPasienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noRegPasienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noRegVaksinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noRekamMedisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noTeleponField;
        
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
        public string alamatPasien {
            get {
                return this.alamatPasienField;
            }
            set {
                if ((object.ReferenceEquals(this.alamatPasienField, value) != true)) {
                    this.alamatPasienField = value;
                    this.RaisePropertyChanged("alamatPasien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idPemerintah {
            get {
                return this.idPemerintahField;
            }
            set {
                if ((object.ReferenceEquals(this.idPemerintahField, value) != true)) {
                    this.idPemerintahField = value;
                    this.RaisePropertyChanged("idPemerintah");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idRS {
            get {
                return this.idRSField;
            }
            set {
                if ((object.ReferenceEquals(this.idRSField, value) != true)) {
                    this.idRSField = value;
                    this.RaisePropertyChanged("idRS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string namaPasien {
            get {
                return this.namaPasienField;
            }
            set {
                if ((object.ReferenceEquals(this.namaPasienField, value) != true)) {
                    this.namaPasienField = value;
                    this.RaisePropertyChanged("namaPasien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nikPasien {
            get {
                return this.nikPasienField;
            }
            set {
                if ((object.ReferenceEquals(this.nikPasienField, value) != true)) {
                    this.nikPasienField = value;
                    this.RaisePropertyChanged("nikPasien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noRegPasien {
            get {
                return this.noRegPasienField;
            }
            set {
                if ((object.ReferenceEquals(this.noRegPasienField, value) != true)) {
                    this.noRegPasienField = value;
                    this.RaisePropertyChanged("noRegPasien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noRegVaksin {
            get {
                return this.noRegVaksinField;
            }
            set {
                if ((object.ReferenceEquals(this.noRegVaksinField, value) != true)) {
                    this.noRegVaksinField = value;
                    this.RaisePropertyChanged("noRegVaksin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noRekamMedis {
            get {
                return this.noRekamMedisField;
            }
            set {
                if ((object.ReferenceEquals(this.noRekamMedisField, value) != true)) {
                    this.noRekamMedisField = value;
                    this.RaisePropertyChanged("noRekamMedis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noTelepon {
            get {
                return this.noTeleponField;
            }
            set {
                if ((object.ReferenceEquals(this.noTeleponField, value) != true)) {
                    this.noTeleponField = value;
                    this.RaisePropertyChanged("noTelepon");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="vaksin", Namespace="http://schemas.datacontract.org/2004/07/WcfRumahSakit")]
    [System.SerializableAttribute()]
    public partial class vaksin : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idProdusenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idVaksinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noRegVaksinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusVPasienField;
        
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
        public string idProdusen {
            get {
                return this.idProdusenField;
            }
            set {
                if ((object.ReferenceEquals(this.idProdusenField, value) != true)) {
                    this.idProdusenField = value;
                    this.RaisePropertyChanged("idProdusen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idVaksin {
            get {
                return this.idVaksinField;
            }
            set {
                if ((this.idVaksinField.Equals(value) != true)) {
                    this.idVaksinField = value;
                    this.RaisePropertyChanged("idVaksin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noRegVaksin {
            get {
                return this.noRegVaksinField;
            }
            set {
                if ((object.ReferenceEquals(this.noRegVaksinField, value) != true)) {
                    this.noRegVaksinField = value;
                    this.RaisePropertyChanged("noRegVaksin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string statusVPasien {
            get {
                return this.statusVPasienField;
            }
            set {
                if ((object.ReferenceEquals(this.statusVPasienField, value) != true)) {
                    this.statusVPasienField = value;
                    this.RaisePropertyChanged("statusVPasien");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddLaporanPenggunaan", ReplyAction="http://tempuri.org/IService1/AddLaporanPenggunaanResponse")]
        bool AddLaporanPenggunaan(RSTrackingVaccine.ServiceReference1.pelaporan_penggunaan data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddLaporanPenggunaan", ReplyAction="http://tempuri.org/IService1/AddLaporanPenggunaanResponse")]
        System.Threading.Tasks.Task<bool> AddLaporanPenggunaanAsync(RSTrackingVaccine.ServiceReference1.pelaporan_penggunaan data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteLaporanPenggunaan", ReplyAction="http://tempuri.org/IService1/DeleteLaporanPenggunaanResponse")]
        bool DeleteLaporanPenggunaan(string idPelaporanP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteLaporanPenggunaan", ReplyAction="http://tempuri.org/IService1/DeleteLaporanPenggunaanResponse")]
        System.Threading.Tasks.Task<bool> DeleteLaporanPenggunaanAsync(string idPelaporanP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPasien", ReplyAction="http://tempuri.org/IService1/GetPasienResponse")]
        RSTrackingVaccine.ServiceReference1.pasien[] GetPasien();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPasien", ReplyAction="http://tempuri.org/IService1/GetPasienResponse")]
        System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference1.pasien[]> GetPasienAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVaksin", ReplyAction="http://tempuri.org/IService1/GetVaksinResponse")]
        RSTrackingVaccine.ServiceReference1.vaksin[] GetVaksin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVaksin", ReplyAction="http://tempuri.org/IService1/GetVaksinResponse")]
        System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference1.vaksin[]> GetVaksinAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : RSTrackingVaccine.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<RSTrackingVaccine.ServiceReference1.IService1>, RSTrackingVaccine.ServiceReference1.IService1 {
        /*internal object pelaporan_penggunaan;*/

        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddLaporanPenggunaan(RSTrackingVaccine.ServiceReference1.pelaporan_penggunaan data) {
            return base.Channel.AddLaporanPenggunaan(data);
        }
        
        public System.Threading.Tasks.Task<bool> AddLaporanPenggunaanAsync(RSTrackingVaccine.ServiceReference1.pelaporan_penggunaan data) {
            return base.Channel.AddLaporanPenggunaanAsync(data);
        }
        
        public bool DeleteLaporanPenggunaan(string idPelaporanP) {
            return base.Channel.DeleteLaporanPenggunaan(idPelaporanP);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteLaporanPenggunaanAsync(string idPelaporanP) {
            return base.Channel.DeleteLaporanPenggunaanAsync(idPelaporanP);
        }
        
        public RSTrackingVaccine.ServiceReference1.pasien[] GetPasien() {
            return base.Channel.GetPasien();
        }
        
        public System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference1.pasien[]> GetPasienAsync() {
            return base.Channel.GetPasienAsync();
        }
        
        public RSTrackingVaccine.ServiceReference1.vaksin[] GetVaksin() {
            return base.Channel.GetVaksin();
        }
        
        public System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference1.vaksin[]> GetVaksinAsync() {
            return base.Channel.GetVaksinAsync();
        }
    }
}
