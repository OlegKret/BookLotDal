using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceBooks.DAL;

namespace WcfServiceBooks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IAccount
    {
        [OperationContract]
        User Login(string login, string password);

        [OperationContract]
        bool Register(User user);

        [OperationContract]
        byte[] GetImage(string imageName);
    }
}
