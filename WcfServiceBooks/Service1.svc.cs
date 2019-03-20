using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceBooks.DAL;

namespace WcfServiceBooks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public BookLotEntities Context { get; } = new BookLotEntities();
        protected DbSet<Books> Table;

        public Books GetBooks(int id)
        {
            Books books = new Books();
            books.BookId = id;
            books.Title = "fake book name";
            return books;
        }

        public int Add(Books entity)
        {
            Table.Add(entity);
            return SaveChanges();
        }

        internal int SaveChanges()
        {
            try
            {
                return Context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw;
            }
            catch (DbUpdateException ex)
            {
                throw;
            }
            catch (CommitFailedException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int AddRange(IList<Books> entities)
        {
            Table.AddRange(entities);
            return SaveChanges();
        }
        public int Save(Books entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public int Delete(Books entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Books GetOne(int? id) => Table.Find(id);

        public List<Books> GetAll() => Table.ToList();

        public List<Books> ExecuteQuery(string sql) => Table.SqlQuery(sql).ToList();

        public int Delete(int id)
        {
            Context.Entry(new Books()
            {
                BookId = id


            }).State = EntityState.Deleted;
            return SaveChanges();
        }
    }
}
