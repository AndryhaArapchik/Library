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
    public class AuthorRepository : IRepository<Author>
    {
        private readonly LDBContext dbContext;
        public AuthorRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Author item)
        {
            dbContext.Authors.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentAuthor = dbContext.Authors.Find(id);
            if (currentAuthor != null)
                dbContext.Authors.Remove(currentAuthor);
        }

        public IEnumerable<Author> Find(Func<Author, bool> predicate)
        {
            return dbContext.Authors.Where(predicate).ToList();
        }

        public Author Get(Guid id)
        {
            return dbContext.Authors.Find(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return dbContext.Authors;
        }

        public void Update(Author item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
