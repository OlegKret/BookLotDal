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
    public class PublisherRepo : BaseRepo<Publishers>, IRepo<Publishers>
    {

        public PublisherRepo()
        {
            Table = Context.Publishers;
        }
        public int Delete(int id)
        {
            Context.Entry(new Publishers()
            {
               PublisherId = id 
             

            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Publishers()
            {
                PublisherId = id, 
                

            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
