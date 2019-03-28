﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookServise.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://OlegKret.somee.com/BOOOOK", ConfigurationName="ServiceReference2.IAccount")]
    public interface IAccount {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Login", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/LoginResponse")]
        WcfServiceBooks.DAL.User Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Login", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/LoginResponse")]
        System.Threading.Tasks.Task<WcfServiceBooks.DAL.User> LoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Register", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/RegisterResponse")]
        bool Register(WcfServiceBooks.DAL.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Register", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(WcfServiceBooks.DAL.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Add", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/AddResponse")]
        int Add(WcfServiceBooks.DAL.User entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Add", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(WcfServiceBooks.DAL.User entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/AddRange", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/AddRangeResponse")]
        int AddRange(WcfServiceBooks.DAL.User[] entities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/AddRange", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/AddRangeResponse")]
        System.Threading.Tasks.Task<int> AddRangeAsync(WcfServiceBooks.DAL.User[] entities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Save", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/SaveResponse")]
        int Save(WcfServiceBooks.DAL.User entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Save", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/SaveResponse")]
        System.Threading.Tasks.Task<int> SaveAsync(WcfServiceBooks.DAL.User entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Delete", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/DeleteResponse")]
        int Delete(WcfServiceBooks.DAL.User entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/Delete", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/DeleteResponse")]
        System.Threading.Tasks.Task<int> DeleteAsync(WcfServiceBooks.DAL.User entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/GetOne", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/GetOneResponse")]
        WcfServiceBooks.DAL.User GetOne(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/GetOne", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/GetOneResponse")]
        System.Threading.Tasks.Task<WcfServiceBooks.DAL.User> GetOneAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/GetAll", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/GetAllResponse")]
        WcfServiceBooks.DAL.User[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/GetAll", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/GetAllResponse")]
        System.Threading.Tasks.Task<WcfServiceBooks.DAL.User[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/ExecuteQuery", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/ExecuteQueryResponse")]
        WcfServiceBooks.DAL.User[] ExecuteQuery(string sql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/ExecuteQuery", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/ExecuteQueryResponse")]
        System.Threading.Tasks.Task<WcfServiceBooks.DAL.User[]> ExecuteQueryAsync(string sql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/ConvertFiltoBite", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/ConvertFiltoBiteResponse")]
        byte[] ConvertFiltoBite(string sPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/ConvertFiltoBite", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/ConvertFiltoBiteResponse")]
        System.Threading.Tasks.Task<byte[]> ConvertFiltoBiteAsync(string sPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/GetStream", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/GetStreamResponse")]
        System.IO.Stream GetStream();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OlegKret.somee.com/BOOOOK/IAccount/GetStream", ReplyAction="http://OlegKret.somee.com/BOOOOK/IAccount/GetStreamResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountChannel : BookServise.ServiceReference2.IAccount, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountClient : System.ServiceModel.ClientBase<BookServise.ServiceReference2.IAccount>, BookServise.ServiceReference2.IAccount {
        
        public AccountClient() {
        }
        
        public AccountClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfServiceBooks.DAL.User Login(string login1, string password) {
            return base.Channel.Login(login1, password);
        }
        
        public System.Threading.Tasks.Task<WcfServiceBooks.DAL.User> LoginAsync(string login, string password) {
            return base.Channel.LoginAsync(login, password);
        }
        
        public bool Register(WcfServiceBooks.DAL.User user) {
            return base.Channel.Register(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(WcfServiceBooks.DAL.User user) {
            return base.Channel.RegisterAsync(user);
        }
        
        public int Add(WcfServiceBooks.DAL.User entity) {
            return base.Channel.Add(entity);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(WcfServiceBooks.DAL.User entity) {
            return base.Channel.AddAsync(entity);
        }
        
        public int AddRange(WcfServiceBooks.DAL.User[] entities) {
            return base.Channel.AddRange(entities);
        }
        
        public System.Threading.Tasks.Task<int> AddRangeAsync(WcfServiceBooks.DAL.User[] entities) {
            return base.Channel.AddRangeAsync(entities);
        }
        
        public int Save(WcfServiceBooks.DAL.User entity) {
            return base.Channel.Save(entity);
        }
        
        public System.Threading.Tasks.Task<int> SaveAsync(WcfServiceBooks.DAL.User entity) {
            return base.Channel.SaveAsync(entity);
        }
        
        public int Delete(WcfServiceBooks.DAL.User entity) {
            return base.Channel.Delete(entity);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(WcfServiceBooks.DAL.User entity) {
            return base.Channel.DeleteAsync(entity);
        }
        
        public WcfServiceBooks.DAL.User GetOne(System.Nullable<int> id) {
            return base.Channel.GetOne(id);
        }
        
        public System.Threading.Tasks.Task<WcfServiceBooks.DAL.User> GetOneAsync(System.Nullable<int> id) {
            return base.Channel.GetOneAsync(id);
        }
        
        public WcfServiceBooks.DAL.User[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<WcfServiceBooks.DAL.User[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public WcfServiceBooks.DAL.User[] ExecuteQuery(string sql) {
            return base.Channel.ExecuteQuery(sql);
        }
        
        public System.Threading.Tasks.Task<WcfServiceBooks.DAL.User[]> ExecuteQueryAsync(string sql) {
            return base.Channel.ExecuteQueryAsync(sql);
        }
        
        public byte[] ConvertFiltoBite(string sPath) {
            return base.Channel.ConvertFiltoBite(sPath);
        }
        
        public System.Threading.Tasks.Task<byte[]> ConvertFiltoBiteAsync(string sPath) {
            return base.Channel.ConvertFiltoBiteAsync(sPath);
        }
        
        public System.IO.Stream GetStream() {
            return base.Channel.GetStream();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync() {
            return base.Channel.GetStreamAsync();
        }
    }
}
