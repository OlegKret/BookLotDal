﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfServiceBooks.DAL
{
    public class BookLotEntities:DbContext
    {
        public BookLotEntities()
           : base("name=BookLotConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public virtual DbSet<Books> BookCategories { get; set; }      
        public virtual DbSet<OrderItems> OrderItem { get; set; }
        
    }
}