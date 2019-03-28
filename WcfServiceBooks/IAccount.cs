using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceBooks.DAL;

namespace WcfServiceBooks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract(Namespace = "http://OlegKret.somee.com/BOOOOK")]
    public interface IAccount
    {
        [OperationContract]
        User Login(string login, string password);

        [OperationContract]
        bool Register(User user);

        [OperationContract]
        int Add(User entity);

        [OperationContract]
        int AddRange(IList<User> entities);

        [OperationContract]
        int Save(User entity);

        [OperationContract]
        int Delete(User entity);

        [OperationContract]
        User GetOne(int? id);

        [OperationContract]
        List<User> GetAll();

        [OperationContract]
        List<User> ExecuteQuery(string sql);

        //[OperationContract]
        //int Delete(int id);

        [OperationContract]
        byte[] ConvertFiltoBite(string sPath);

        [OperationContract]
        Stream GetStream();

        

        //[OperationContract]
        //[WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "PostImage?fileName={fileName}&Ext={Ext}&Path={Path}", Method = "Post")]
        //string PostImage(Stream sm, string fileName, string Ext, string Path);

        //[OperationContract]
        //byte[] GetImage(string imageName);
    }
}
