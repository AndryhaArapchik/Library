using DataAccessLayer.Contexts;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly LDBContext dbContext;
        public BookRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Book item)
        {
            dbContext.Books.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentBook = dbContext.Books.Find(id);
            if (currentBook != null)
                dbContext.Books.Remove(currentBook);
        }

        public IEnumerable<Book> Find(Func<Book, bool> predicate)
        {
            return dbContext.Books.Where(predicate).ToList();
        }

        public Book Get(Guid id)
        {
            return dbContext.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return dbContext.Books;
        }

        public void Update(Book item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
