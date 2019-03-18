using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookLotDal.Models;

namespace BookLotDal.EF
{
    //public class MyDataInitializer : DropCreateDatabaseIfModelChanges<BookLotEntities>
    public class DataInitializer : DropCreateDatabaseAlways<BookLotEntities>
    //public class DataInitializer : DropCreateDatabaseIfModelChanges<BookLotEntities>
    {
        protected override void Seed(BookLotEntities context)
        {

            var authors = new List<Authors>
                {
                    new Authors { AuthorFirstName = "Andrew",  AuthorLastName = "Troelson",
                      },
                    new Authors {AuthorFirstName = "Philip", AuthorLastName = "Japikse"
                      },
                    new Authors {AuthorFirstName = "Penelope", AuthorLastName = "Fitzgerald"
                      },
                     new Authors {AuthorFirstName = " Gail", AuthorLastName = "Honeyman"},
                    new Authors {AuthorFirstName = "Sally", AuthorLastName = "Rooney"},
                     new Authors {AuthorFirstName = "George", AuthorLastName = "Orwell"},
                };
            authors.ForEach(x => context.Author.Add(x));



            var pablishers = new List<Publishers>
                {
                    new Publishers { PublisherName="APRESS"
                      },
                    new Publishers { PublisherName="WILLYAMS"},
                    new Publishers { PublisherName="UJH"},
                     new Publishers {PublisherName="JEY"},

                };
            pablishers.ForEach(x => context.Publishers.Add(x));

            var book = new List<Books>
                {
                    new Books {  Title = "C#",  ISBN = "f156156156", Genre="Computerscince",
                    Type="dfgfdg", PublicationYear="fdgfzdgfdzg", Publishers=pablishers[0],
                     Price=750, Condition="gfdgfsdgasdgdfg", Authors=authors[4], AuthorId=2,
                      PublisherId=1,
                     },
                    new Books {  Title = "C#", ISBN = "f156156156", Genre="Computerscince",
                    Type="dfgfdg", PublicationYear="fdgfzdgfdzg", Publishers=pablishers[0],
                     Price=750, Condition="gfdgfsdgasdgdfg", Authors=authors[2] },
                   new Books {  Title = "C#", ISBN = "f156156156", Genre="Computerscince",
                    Type="dfgfdg", PublicationYear="fdgfzdgfdzg", Publishers=pablishers[0],
                     Price=750, Condition="gfdgfsdgasdgdfg", Authors=authors[4] },
                    new Books {  Title = "C#", ISBN = "f156156156", Genre="Computerscince",
                    Type="dfgfdg", PublicationYear="fdgfzdgfdzg", Publishers=pablishers[0],
                     Price=750, Condition="gfdgfsdgasdgdfg", Authors=authors[1] },
                };
            book.ForEach(x => context.BookCategories.Add(x));

            var salesbook = new List<SalesBook>
                {
                    new SalesBook { TitleAction="Winter MegaSale", Books=book[2],
                      },

                };
            salesbook.ForEach(x => context.GetBooks.Add(x));

            var orderitims = new List<OrderItem>
                {
                    new OrderItem {  Quantity  =6, Books=book[1],   Price=250, /*SalesBook=salesbook[1]*/ },
                    new OrderItem {Quantity  =6,  Price=250, Books=book[3],  /*SalesBook=salesbook[2]*/ },
                };
            orderitims.ForEach(x => context.OrderItem.Add(x));



            var customers = new List<Customer>
                     {
                    new Customer {FirstName = "Dave", LastName = "Brenner",  StreetNumber="10",

                    StreetName="Wall", PostalCode="15615", Province="London", PhoneNumber="njkn"},
                    new Customer {FirstName = "Matt", LastName = "Walton",  PhoneNumber="6161",
                     PostalCode="56416584", Province="nkjbkbu", StreetName="nick", StreetNumber="14",
                    /* Country="USA"*/},
                    new Customer {FirstName = "Steve", LastName = "Hagen",  PhoneNumber="6161",
                     PostalCode="56416584", Province="nkjbkbu", StreetName="nick", StreetNumber="14",/*Country="GB"*/},
                    new Customer {FirstName = "Pat", LastName = "Walton",  PhoneNumber="6161",
                     PostalCode="56416584", Province="nkjbkbu", StreetName="nick", StreetNumber="14",

                    /*Country="Ukraine"*/},
                    new Customer {FirstName = "Bad", LastName = "Customer",  PhoneNumber="6161",
                     PostalCode="56416584", Province="nkjbkbu",  StreetName="nick",  StreetNumber="14",
                    /*Country="France"*/},
                };
            customers.ForEach(x => context.Customers.Add(x));

            var orders = new List<Orders>
                {
                    new Orders {OrderDate = DateTime.UtcNow, Shipping="UK", Subtotal=1920, Total=3000,
                       Customer=customers[1], CustId=1, OrderId=3  },
                    new Orders {OrderDate = DateTime.UtcNow, Shipping="UK", Subtotal=1920, Total=3000,
                      Customer=customers[1], CustId=3, OrderId=2 },
                    new Orders {OrderDate = DateTime.UtcNow, Shipping="UK", Subtotal=1920, Total=3000,
                     Customer=customers[2], CustId=1, OrderId=5},
                    new Orders {OrderDate = DateTime.UtcNow, Shipping="UK", Subtotal=1920, Total=3000,
                      Customer=customers[3], CustId=7, OrderId=14},
                };
            orders.ForEach(x => context.Ordered.Add(x));

            context.SaveChanges();

        }
    }
}
