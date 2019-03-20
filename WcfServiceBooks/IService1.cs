using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceBooks.DAL;

namespace WcfServiceBooks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Books GetBooks(int id);

        [OperationContract]
        int Add(Books entity);

        [OperationContract]
        int AddRange(IList<Books> entities);

        [OperationContract]
        int Save(Books entity);

        [OperationContract]
        int Delete(Books entity);

        [OperationContract]
        Books GetOne(int? id);

        [OperationContract]
        List<Books> GetAll();

        [OperationContract]
        List<Books> ExecuteQuery(string sql);

        int Delete(int id);
    }


}
