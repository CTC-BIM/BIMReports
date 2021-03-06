﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace BIMReports.com.cbimtech.MemberServices {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MemberServiceSoap", Namespace="http://services.cbimtech.com/WebServices/")]
    public partial class MemberService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DanhSachMemberOperationCompleted;
        
        private System.Threading.SendOrPostCallback MemberbyIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback MemberByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback MemberbyUsernameOperationCompleted;
        
        private System.Threading.SendOrPostCallback MemberbyTinhtrangLamViecOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MemberService() {
            this.Url = global::BIMReports.Properties.Settings.Default.BIMReports_com_cbimtech_MemberServices_MemberService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DanhSachMemberCompletedEventHandler DanhSachMemberCompleted;
        
        /// <remarks/>
        public event MemberbyIDCompletedEventHandler MemberbyIDCompleted;
        
        /// <remarks/>
        public event MemberByNameCompletedEventHandler MemberByNameCompleted;
        
        /// <remarks/>
        public event MemberbyUsernameCompletedEventHandler MemberbyUsernameCompleted;
        
        /// <remarks/>
        public event MemberbyTinhtrangLamViecCompletedEventHandler MemberbyTinhtrangLamViecCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/DanhSachMember", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MemberOutput[] DanhSachMember() {
            object[] results = this.Invoke("DanhSachMember", new object[0]);
            return ((MemberOutput[])(results[0]));
        }
        
        /// <remarks/>
        public void DanhSachMemberAsync() {
            this.DanhSachMemberAsync(null);
        }
        
        /// <remarks/>
        public void DanhSachMemberAsync(object userState) {
            if ((this.DanhSachMemberOperationCompleted == null)) {
                this.DanhSachMemberOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDanhSachMemberOperationCompleted);
            }
            this.InvokeAsync("DanhSachMember", new object[0], this.DanhSachMemberOperationCompleted, userState);
        }
        
        private void OnDanhSachMemberOperationCompleted(object arg) {
            if ((this.DanhSachMemberCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DanhSachMemberCompleted(this, new DanhSachMemberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/MemberbyID", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MemberOutput MemberbyID(int id) {
            object[] results = this.Invoke("MemberbyID", new object[] {
                        id});
            return ((MemberOutput)(results[0]));
        }
        
        /// <remarks/>
        public void MemberbyIDAsync(int id) {
            this.MemberbyIDAsync(id, null);
        }
        
        /// <remarks/>
        public void MemberbyIDAsync(int id, object userState) {
            if ((this.MemberbyIDOperationCompleted == null)) {
                this.MemberbyIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMemberbyIDOperationCompleted);
            }
            this.InvokeAsync("MemberbyID", new object[] {
                        id}, this.MemberbyIDOperationCompleted, userState);
        }
        
        private void OnMemberbyIDOperationCompleted(object arg) {
            if ((this.MemberbyIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MemberbyIDCompleted(this, new MemberbyIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/MemberByName", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MemberOutput MemberByName(string name) {
            object[] results = this.Invoke("MemberByName", new object[] {
                        name});
            return ((MemberOutput)(results[0]));
        }
        
        /// <remarks/>
        public void MemberByNameAsync(string name) {
            this.MemberByNameAsync(name, null);
        }
        
        /// <remarks/>
        public void MemberByNameAsync(string name, object userState) {
            if ((this.MemberByNameOperationCompleted == null)) {
                this.MemberByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMemberByNameOperationCompleted);
            }
            this.InvokeAsync("MemberByName", new object[] {
                        name}, this.MemberByNameOperationCompleted, userState);
        }
        
        private void OnMemberByNameOperationCompleted(object arg) {
            if ((this.MemberByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MemberByNameCompleted(this, new MemberByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/MemberbyUsername", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MemberOutput MemberbyUsername(string username) {
            object[] results = this.Invoke("MemberbyUsername", new object[] {
                        username});
            return ((MemberOutput)(results[0]));
        }
        
        /// <remarks/>
        public void MemberbyUsernameAsync(string username) {
            this.MemberbyUsernameAsync(username, null);
        }
        
        /// <remarks/>
        public void MemberbyUsernameAsync(string username, object userState) {
            if ((this.MemberbyUsernameOperationCompleted == null)) {
                this.MemberbyUsernameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMemberbyUsernameOperationCompleted);
            }
            this.InvokeAsync("MemberbyUsername", new object[] {
                        username}, this.MemberbyUsernameOperationCompleted, userState);
        }
        
        private void OnMemberbyUsernameOperationCompleted(object arg) {
            if ((this.MemberbyUsernameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MemberbyUsernameCompleted(this, new MemberbyUsernameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/MemberbyTinhtrangLamViec", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MemberOutput[] MemberbyTinhtrangLamViec(string tinhtrang) {
            object[] results = this.Invoke("MemberbyTinhtrangLamViec", new object[] {
                        tinhtrang});
            return ((MemberOutput[])(results[0]));
        }
        
        /// <remarks/>
        public void MemberbyTinhtrangLamViecAsync(string tinhtrang) {
            this.MemberbyTinhtrangLamViecAsync(tinhtrang, null);
        }
        
        /// <remarks/>
        public void MemberbyTinhtrangLamViecAsync(string tinhtrang, object userState) {
            if ((this.MemberbyTinhtrangLamViecOperationCompleted == null)) {
                this.MemberbyTinhtrangLamViecOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMemberbyTinhtrangLamViecOperationCompleted);
            }
            this.InvokeAsync("MemberbyTinhtrangLamViec", new object[] {
                        tinhtrang}, this.MemberbyTinhtrangLamViecOperationCompleted, userState);
        }
        
        private void OnMemberbyTinhtrangLamViecOperationCompleted(object arg) {
            if ((this.MemberbyTinhtrangLamViecCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MemberbyTinhtrangLamViecCompleted(this, new MemberbyTinhtrangLamViecCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.cbimtech.com/WebServices/")]
    public partial class MemberOutput {
        
        private int idField;
        
        private string softNameField;
        
        private string userNameField;
        
        private string passwordField;
        
        private string userTypeField;
        
        private string departmentField;
        
        private string userStatusField;
        
        private string imageField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string SoftName {
            get {
                return this.softNameField;
            }
            set {
                this.softNameField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string UserType {
            get {
                return this.userTypeField;
            }
            set {
                this.userTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        public string UserStatus {
            get {
                return this.userStatusField;
            }
            set {
                this.userStatusField = value;
            }
        }
        
        /// <remarks/>
        public string Image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void DanhSachMemberCompletedEventHandler(object sender, DanhSachMemberCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DanhSachMemberCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DanhSachMemberCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MemberOutput[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MemberOutput[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void MemberbyIDCompletedEventHandler(object sender, MemberbyIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MemberbyIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MemberbyIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MemberOutput Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MemberOutput)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void MemberByNameCompletedEventHandler(object sender, MemberByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MemberByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MemberByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MemberOutput Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MemberOutput)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void MemberbyUsernameCompletedEventHandler(object sender, MemberbyUsernameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MemberbyUsernameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MemberbyUsernameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MemberOutput Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MemberOutput)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void MemberbyTinhtrangLamViecCompletedEventHandler(object sender, MemberbyTinhtrangLamViecCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MemberbyTinhtrangLamViecCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MemberbyTinhtrangLamViecCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MemberOutput[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MemberOutput[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591