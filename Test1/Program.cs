using BookLotDal.EF;
using BookLotDal.Models;
using BookLotDal.Repos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Database.SetInitializer(new DataInitializer());
            new BookLotEntities().Database.Initialize(true);
            //var pablishers = new List<Publishers> { new Publishers { PublisherName="UJH"},
            //         new Publishers {PublisherName="JEY"}};

            //var authors = new List<Authors>
            //    {
            //        new Authors { AuthorFirstName = "Andrew",  AuthorLastName = "Troelson"
            //          },
            //        new Authors {AuthorFirstName = "Penelope", AuthorLastName = "Fitzgerald"
            //          },
            //         new Authors {AuthorFirstName = " Gail", AuthorLastName = "Honeyman"},
            //        new Authors {AuthorFirstName = "Sally", AuthorLastName = "Rooney"},
            //    };
            //PrintAllInventory();
            //var book1 = new Books()
            //{
            //    Title = "Love",
            //    ISBN = "156415614",
            //    Genre = "Dedective",
            //    Type = "jkbhb",
            //    PublicationYear = "2015",
            //    Price = 475,
            //    Condition = "hubhkbhjbhj",
            //    Publishers = pablishers[0],
            //    Authors = authors[0]
            //};
            //AddNewRecord(book1);
            //var book2 = new Books()
            //{
            //    Title = "Gangfr",
            //    ISBN = "156kbhjbhjb",
            //    Genre = "Dedective",
            //    Type = "jkbhb",
            //    PublicationYear = "2019",
            //    Price = 475,
            //    Condition = "hubhkbhjbhj",
            //    Publishers = pablishers[0],
            //    Authors = authors[3]
            //};
            //AddNewRecord(book2);
            //AddNewRecords(new List<Books> { book1, book2 });

            //UpdateRecord(book1.BookId);
            PrintAllInventory();
            PrintAllOrders();
            ReadLine();
        }
        private static void PrintAllInventory()
        {
            using (var repo = new BooksRepo())
            {
                foreach (Books c in repo.GetAll())
                {
                    WriteLine(c);
                }
            }
           
        }

        private static void PrintAllOrders()
        {
            using (var repo = new OrderRepo())
            {
                foreach (Orders c in repo.GetAll())
                {
                    WriteLine(c);
                }
            }

        }
        private static void AddNewRecord(Books books)
        {
            using (var repo = new BooksRepo())
            {
                repo.Add(books);
            }
        }
        private static void AddNewRecords(IList<Books> books)
        {
            using (var repo = new BooksRepo())
            {
                repo.AddRange(books);
            }
        }
        private static void UpdateRecord(int bookId)
        {
            using (var repo = new BooksRepo())
            {
                var bookToUpdate = repo.GetOne(bookId);
                    if(bookToUpdate!=null)
                {
                    WriteLine("Before change: " + repo.Context.Entry(bookToUpdate).State);
                    bookToUpdate.Genre = "bjhbvjhvj";
                    WriteLine("After change: " + repo.Context.Entry(bookToUpdate).State);
                    repo.Save(bookToUpdate);
                    WriteLine("After Save: " + repo.Context.Entry(bookToUpdate).State);
                }
            }
        }
        
    }
}
