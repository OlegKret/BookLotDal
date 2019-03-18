using BookLotDal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLotDal.Repos
{
    public class AuthorsRepo : BaseRepo<Authors>, IRepo<Authors>
    {
        public AuthorsRepo()
        {
            Table = Context.Author;
        }
        public int Delete(int id)
        {
            Context.Entry(new Authors()
            {
                AuthorId = id,
                

            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Authors()
            {
                AuthorId = id,
                

            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }



    }
}

