﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCTismartLibrary.TismartLibraryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCFTismartLibrary")]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookReservation", Namespace="http://schemas.datacontract.org/2004/07/WCFTismartLibrary")]
    [System.SerializableAttribute()]
    public partial class BookReservation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateTimeReservationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsReservedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateTimeReservation {
            get {
                return this.DateTimeReservationField;
            }
            set {
                if ((object.ReferenceEquals(this.DateTimeReservationField, value) != true)) {
                    this.DateTimeReservationField = value;
                    this.RaisePropertyChanged("DateTimeReservation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsReserved {
            get {
                return this.IsReservedField;
            }
            set {
                if ((this.IsReservedField.Equals(value) != true)) {
                    this.IsReservedField = value;
                    this.RaisePropertyChanged("IsReserved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/WCFTismartLibrary")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsReservedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsReserved {
            get {
                return this.IsReservedField;
            }
            set {
                if ((this.IsReservedField.Equals(value) != true)) {
                    this.IsReservedField = value;
                    this.RaisePropertyChanged("IsReserved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WCFTismartLibrary")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserCredentials", Namespace="http://schemas.datacontract.org/2004/07/WCFTismartLibrary")]
    [System.SerializableAttribute()]
    public partial class UserCredentials : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TismartLibraryService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MVCTismartLibrary.TismartLibraryService.CompositeType GetDataUsingDataContract(MVCTismartLibrary.TismartLibraryService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.CompositeType> GetDataUsingDataContractAsync(MVCTismartLibrary.TismartLibraryService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListBooksReservations", ReplyAction="http://tempuri.org/IService1/ListBooksReservationsResponse")]
        MVCTismartLibrary.TismartLibraryService.BookReservation[] ListBooksReservations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListBooksReservations", ReplyAction="http://tempuri.org/IService1/ListBooksReservationsResponse")]
        System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.BookReservation[]> ListBooksReservationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BookReservation", ReplyAction="http://tempuri.org/IService1/BookReservationResponse")]
        void BookReservation(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BookReservation", ReplyAction="http://tempuri.org/IService1/BookReservationResponse")]
        System.Threading.Tasks.Task BookReservationAsync(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BookSelection", ReplyAction="http://tempuri.org/IService1/BookSelectionResponse")]
        MVCTismartLibrary.TismartLibraryService.Book BookSelection(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BookSelection", ReplyAction="http://tempuri.org/IService1/BookSelectionResponse")]
        System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.Book> BookSelectionAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        MVCTismartLibrary.TismartLibraryService.User GetUser(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.User> GetUserAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsValidUser", ReplyAction="http://tempuri.org/IService1/IsValidUserResponse")]
        bool IsValidUser(MVCTismartLibrary.TismartLibraryService.UserCredentials userCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsValidUser", ReplyAction="http://tempuri.org/IService1/IsValidUserResponse")]
        System.Threading.Tasks.Task<bool> IsValidUserAsync(MVCTismartLibrary.TismartLibraryService.UserCredentials userCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReservationQueue", ReplyAction="http://tempuri.org/IService1/ReservationQueueResponse")]
        void ReservationQueue(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReservationQueue", ReplyAction="http://tempuri.org/IService1/ReservationQueueResponse")]
        System.Threading.Tasks.Task ReservationQueueAsync(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsUserInWatingList", ReplyAction="http://tempuri.org/IService1/IsUserInWatingListResponse")]
        bool IsUserInWatingList(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsUserInWatingList", ReplyAction="http://tempuri.org/IService1/IsUserInWatingListResponse")]
        System.Threading.Tasks.Task<bool> IsUserInWatingListAsync(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WaitingListForBookCounter", ReplyAction="http://tempuri.org/IService1/WaitingListForBookCounterResponse")]
        int WaitingListForBookCounter(MVCTismartLibrary.TismartLibraryService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WaitingListForBookCounter", ReplyAction="http://tempuri.org/IService1/WaitingListForBookCounterResponse")]
        System.Threading.Tasks.Task<int> WaitingListForBookCounterAsync(MVCTismartLibrary.TismartLibraryService.Book book);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVCTismartLibrary.TismartLibraryService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVCTismartLibrary.TismartLibraryService.IService1>, MVCTismartLibrary.TismartLibraryService.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public MVCTismartLibrary.TismartLibraryService.CompositeType GetDataUsingDataContract(MVCTismartLibrary.TismartLibraryService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.CompositeType> GetDataUsingDataContractAsync(MVCTismartLibrary.TismartLibraryService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public MVCTismartLibrary.TismartLibraryService.BookReservation[] ListBooksReservations() {
            return base.Channel.ListBooksReservations();
        }
        
        public System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.BookReservation[]> ListBooksReservationsAsync() {
            return base.Channel.ListBooksReservationsAsync();
        }
        
        public void BookReservation(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user) {
            base.Channel.BookReservation(book, user);
        }
        
        public System.Threading.Tasks.Task BookReservationAsync(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user) {
            return base.Channel.BookReservationAsync(book, user);
        }
        
        public MVCTismartLibrary.TismartLibraryService.Book BookSelection(int id) {
            return base.Channel.BookSelection(id);
        }
        
        public System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.Book> BookSelectionAsync(int id) {
            return base.Channel.BookSelectionAsync(id);
        }
        
        public MVCTismartLibrary.TismartLibraryService.User GetUser(string email) {
            return base.Channel.GetUser(email);
        }
        
        public System.Threading.Tasks.Task<MVCTismartLibrary.TismartLibraryService.User> GetUserAsync(string email) {
            return base.Channel.GetUserAsync(email);
        }
        
        public bool IsValidUser(MVCTismartLibrary.TismartLibraryService.UserCredentials userCredentials) {
            return base.Channel.IsValidUser(userCredentials);
        }
        
        public System.Threading.Tasks.Task<bool> IsValidUserAsync(MVCTismartLibrary.TismartLibraryService.UserCredentials userCredentials) {
            return base.Channel.IsValidUserAsync(userCredentials);
        }
        
        public void ReservationQueue(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user) {
            base.Channel.ReservationQueue(book, user);
        }
        
        public System.Threading.Tasks.Task ReservationQueueAsync(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user) {
            return base.Channel.ReservationQueueAsync(book, user);
        }
        
        public bool IsUserInWatingList(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user) {
            return base.Channel.IsUserInWatingList(book, user);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserInWatingListAsync(MVCTismartLibrary.TismartLibraryService.Book book, MVCTismartLibrary.TismartLibraryService.User user) {
            return base.Channel.IsUserInWatingListAsync(book, user);
        }
        
        public int WaitingListForBookCounter(MVCTismartLibrary.TismartLibraryService.Book book) {
            return base.Channel.WaitingListForBookCounter(book);
        }
        
        public System.Threading.Tasks.Task<int> WaitingListForBookCounterAsync(MVCTismartLibrary.TismartLibraryService.Book book) {
            return base.Channel.WaitingListForBookCounterAsync(book);
        }
    }
}
