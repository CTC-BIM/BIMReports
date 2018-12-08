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

namespace BIMReports.com.cbimtech.ProjectServices {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ProjectServiceSoap", Namespace="http://services.cbimtech.com/WebServices/")]
    public partial class ProjectService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetProjectListOperationCompleted;
        
        private System.Threading.SendOrPostCallback TimDuAnTheoTenOperationCompleted;
        
        private System.Threading.SendOrPostCallback TimDuAnTheoIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback TimDuAnTheoScopeOperationCompleted;
        
        private System.Threading.SendOrPostCallback TimDuAnTheoMemberIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback TimDuAnTheoMemIDStatusOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProjectService() {
            this.Url = global::BIMReports.Properties.Settings.Default.BIMReports_com_cbimtech_ProjectServices_ProjectService;
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
        public event GetProjectListCompletedEventHandler GetProjectListCompleted;
        
        /// <remarks/>
        public event TimDuAnTheoTenCompletedEventHandler TimDuAnTheoTenCompleted;
        
        /// <remarks/>
        public event TimDuAnTheoIdCompletedEventHandler TimDuAnTheoIdCompleted;
        
        /// <remarks/>
        public event TimDuAnTheoScopeCompletedEventHandler TimDuAnTheoScopeCompleted;
        
        /// <remarks/>
        public event TimDuAnTheoMemberIDCompletedEventHandler TimDuAnTheoMemberIDCompleted;
        
        /// <remarks/>
        public event TimDuAnTheoMemIDStatusCompletedEventHandler TimDuAnTheoMemIDStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/GetProjectList", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DuAnOutput[] GetProjectList() {
            object[] results = this.Invoke("GetProjectList", new object[0]);
            return ((DuAnOutput[])(results[0]));
        }
        
        /// <remarks/>
        public void GetProjectListAsync() {
            this.GetProjectListAsync(null);
        }
        
        /// <remarks/>
        public void GetProjectListAsync(object userState) {
            if ((this.GetProjectListOperationCompleted == null)) {
                this.GetProjectListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProjectListOperationCompleted);
            }
            this.InvokeAsync("GetProjectList", new object[0], this.GetProjectListOperationCompleted, userState);
        }
        
        private void OnGetProjectListOperationCompleted(object arg) {
            if ((this.GetProjectListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProjectListCompleted(this, new GetProjectListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/TimDuAnTheoTen", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DuAnOutput TimDuAnTheoTen(string name) {
            object[] results = this.Invoke("TimDuAnTheoTen", new object[] {
                        name});
            return ((DuAnOutput)(results[0]));
        }
        
        /// <remarks/>
        public void TimDuAnTheoTenAsync(string name) {
            this.TimDuAnTheoTenAsync(name, null);
        }
        
        /// <remarks/>
        public void TimDuAnTheoTenAsync(string name, object userState) {
            if ((this.TimDuAnTheoTenOperationCompleted == null)) {
                this.TimDuAnTheoTenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTimDuAnTheoTenOperationCompleted);
            }
            this.InvokeAsync("TimDuAnTheoTen", new object[] {
                        name}, this.TimDuAnTheoTenOperationCompleted, userState);
        }
        
        private void OnTimDuAnTheoTenOperationCompleted(object arg) {
            if ((this.TimDuAnTheoTenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TimDuAnTheoTenCompleted(this, new TimDuAnTheoTenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/TimDuAnTheoId", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DuAnOutput TimDuAnTheoId(string id) {
            object[] results = this.Invoke("TimDuAnTheoId", new object[] {
                        id});
            return ((DuAnOutput)(results[0]));
        }
        
        /// <remarks/>
        public void TimDuAnTheoIdAsync(string id) {
            this.TimDuAnTheoIdAsync(id, null);
        }
        
        /// <remarks/>
        public void TimDuAnTheoIdAsync(string id, object userState) {
            if ((this.TimDuAnTheoIdOperationCompleted == null)) {
                this.TimDuAnTheoIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTimDuAnTheoIdOperationCompleted);
            }
            this.InvokeAsync("TimDuAnTheoId", new object[] {
                        id}, this.TimDuAnTheoIdOperationCompleted, userState);
        }
        
        private void OnTimDuAnTheoIdOperationCompleted(object arg) {
            if ((this.TimDuAnTheoIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TimDuAnTheoIdCompleted(this, new TimDuAnTheoIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/TimDuAnTheoScope", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DuAnOutput[] TimDuAnTheoScope(string scope) {
            object[] results = this.Invoke("TimDuAnTheoScope", new object[] {
                        scope});
            return ((DuAnOutput[])(results[0]));
        }
        
        /// <remarks/>
        public void TimDuAnTheoScopeAsync(string scope) {
            this.TimDuAnTheoScopeAsync(scope, null);
        }
        
        /// <remarks/>
        public void TimDuAnTheoScopeAsync(string scope, object userState) {
            if ((this.TimDuAnTheoScopeOperationCompleted == null)) {
                this.TimDuAnTheoScopeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTimDuAnTheoScopeOperationCompleted);
            }
            this.InvokeAsync("TimDuAnTheoScope", new object[] {
                        scope}, this.TimDuAnTheoScopeOperationCompleted, userState);
        }
        
        private void OnTimDuAnTheoScopeOperationCompleted(object arg) {
            if ((this.TimDuAnTheoScopeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TimDuAnTheoScopeCompleted(this, new TimDuAnTheoScopeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/TimDuAnTheoMemberID", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DuAnOutput[] TimDuAnTheoMemberID(int memberID) {
            object[] results = this.Invoke("TimDuAnTheoMemberID", new object[] {
                        memberID});
            return ((DuAnOutput[])(results[0]));
        }
        
        /// <remarks/>
        public void TimDuAnTheoMemberIDAsync(int memberID) {
            this.TimDuAnTheoMemberIDAsync(memberID, null);
        }
        
        /// <remarks/>
        public void TimDuAnTheoMemberIDAsync(int memberID, object userState) {
            if ((this.TimDuAnTheoMemberIDOperationCompleted == null)) {
                this.TimDuAnTheoMemberIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTimDuAnTheoMemberIDOperationCompleted);
            }
            this.InvokeAsync("TimDuAnTheoMemberID", new object[] {
                        memberID}, this.TimDuAnTheoMemberIDOperationCompleted, userState);
        }
        
        private void OnTimDuAnTheoMemberIDOperationCompleted(object arg) {
            if ((this.TimDuAnTheoMemberIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TimDuAnTheoMemberIDCompleted(this, new TimDuAnTheoMemberIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.cbimtech.com/WebServices/TimDuAnTheoMemIDStatus", RequestNamespace="http://services.cbimtech.com/WebServices/", ResponseNamespace="http://services.cbimtech.com/WebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DuAnOutput[] TimDuAnTheoMemIDStatus(int memberID, string projectState) {
            object[] results = this.Invoke("TimDuAnTheoMemIDStatus", new object[] {
                        memberID,
                        projectState});
            return ((DuAnOutput[])(results[0]));
        }
        
        /// <remarks/>
        public void TimDuAnTheoMemIDStatusAsync(int memberID, string projectState) {
            this.TimDuAnTheoMemIDStatusAsync(memberID, projectState, null);
        }
        
        /// <remarks/>
        public void TimDuAnTheoMemIDStatusAsync(int memberID, string projectState, object userState) {
            if ((this.TimDuAnTheoMemIDStatusOperationCompleted == null)) {
                this.TimDuAnTheoMemIDStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTimDuAnTheoMemIDStatusOperationCompleted);
            }
            this.InvokeAsync("TimDuAnTheoMemIDStatus", new object[] {
                        memberID,
                        projectState}, this.TimDuAnTheoMemIDStatusOperationCompleted, userState);
        }
        
        private void OnTimDuAnTheoMemIDStatusOperationCompleted(object arg) {
            if ((this.TimDuAnTheoMemIDStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TimDuAnTheoMemIDStatusCompleted(this, new TimDuAnTheoMemIDStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class DuAnOutput {
        
        private string maDuAnField;
        
        private string tenDuAnField;
        
        private string bIMmemberField;
        
        private string projectStateField;
        
        private string bIMMEPField;
        
        private string aRCmodelField;
        
        private string sTRmodelField;
        
        private string mEPmodelField;
        
        private string propjectStatusField;
        
        private string projectPhaseField;
        
        private string projectScopeField;
        
        /// <remarks/>
        public string MaDuAn {
            get {
                return this.maDuAnField;
            }
            set {
                this.maDuAnField = value;
            }
        }
        
        /// <remarks/>
        public string TenDuAn {
            get {
                return this.tenDuAnField;
            }
            set {
                this.tenDuAnField = value;
            }
        }
        
        /// <remarks/>
        public string BIMmember {
            get {
                return this.bIMmemberField;
            }
            set {
                this.bIMmemberField = value;
            }
        }
        
        /// <remarks/>
        public string ProjectState {
            get {
                return this.projectStateField;
            }
            set {
                this.projectStateField = value;
            }
        }
        
        /// <remarks/>
        public string BIMMEP {
            get {
                return this.bIMMEPField;
            }
            set {
                this.bIMMEPField = value;
            }
        }
        
        /// <remarks/>
        public string ARCmodel {
            get {
                return this.aRCmodelField;
            }
            set {
                this.aRCmodelField = value;
            }
        }
        
        /// <remarks/>
        public string STRmodel {
            get {
                return this.sTRmodelField;
            }
            set {
                this.sTRmodelField = value;
            }
        }
        
        /// <remarks/>
        public string MEPmodel {
            get {
                return this.mEPmodelField;
            }
            set {
                this.mEPmodelField = value;
            }
        }
        
        /// <remarks/>
        public string propjectStatus {
            get {
                return this.propjectStatusField;
            }
            set {
                this.propjectStatusField = value;
            }
        }
        
        /// <remarks/>
        public string projectPhase {
            get {
                return this.projectPhaseField;
            }
            set {
                this.projectPhaseField = value;
            }
        }
        
        /// <remarks/>
        public string projectScope {
            get {
                return this.projectScopeField;
            }
            set {
                this.projectScopeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProjectListCompletedEventHandler(object sender, GetProjectListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProjectListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProjectListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DuAnOutput[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DuAnOutput[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void TimDuAnTheoTenCompletedEventHandler(object sender, TimDuAnTheoTenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimDuAnTheoTenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TimDuAnTheoTenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DuAnOutput Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DuAnOutput)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void TimDuAnTheoIdCompletedEventHandler(object sender, TimDuAnTheoIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimDuAnTheoIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TimDuAnTheoIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DuAnOutput Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DuAnOutput)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void TimDuAnTheoScopeCompletedEventHandler(object sender, TimDuAnTheoScopeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimDuAnTheoScopeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TimDuAnTheoScopeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DuAnOutput[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DuAnOutput[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void TimDuAnTheoMemberIDCompletedEventHandler(object sender, TimDuAnTheoMemberIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimDuAnTheoMemberIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TimDuAnTheoMemberIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DuAnOutput[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DuAnOutput[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void TimDuAnTheoMemIDStatusCompletedEventHandler(object sender, TimDuAnTheoMemIDStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimDuAnTheoMemIDStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TimDuAnTheoMemIDStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DuAnOutput[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DuAnOutput[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591