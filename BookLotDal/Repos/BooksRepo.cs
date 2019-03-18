using BookLotDal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLotDal.Repos
{

    public class BooksRepo : BaseRepo<Books>, IRepo<Books>
    {
        public BooksRepo()
        {
            Table = Context.BookCategories;
        }
        public int Delete(int id)
        {
            Context.Entry(new Books()
            {
                BookId = id
                

            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Books()
            {
                BookId = id,
                

            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

    }

}

