namespace BookLotDal.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using BookLotDal.Models;

    public class BookLotEntities : DbContext
    {
        
        public BookLotEntities()
            : base("name=BookLotConnection")
        {
            
        }


        public virtual DbSet<Authors> Author { get; set; }
        public virtual DbSet<Books> BookCategories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SalesBook> GetBooks { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Orders> Ordered { get; set; }
        public virtual DbSet<Publishers> Publishers { get; set; }

    }
   
    
}