using BookLotDal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLotDal.Repos
{
    public class RepoSalesBook : BaseRepo<SalesBook>, IRepo<SalesBook>
    {

        public RepoSalesBook()
        {
            Table = Context.GetBooks;
        }
        public int Delete(int id)
        {
            Context.Entry(new SalesBook()
            {
                SalesBookId = id,
             

            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new SalesBook()
            {
                SalesBookId = id
               

            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
