using BookLotDal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLotDal.Repos
{
    public class OrderItemsRepo : BaseRepo<OrderItem>, IRepo<OrderItem>
    {
        public OrderItemsRepo()
        {
            Table = Context.OrderItem;
        }
        public int Delete(int id)
        {
            Context.Entry(new OrderItem()
            {
                OrderId = id,
              

            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new OrderItem()
            {
                OrderId = id,
                

            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }



    }
}

