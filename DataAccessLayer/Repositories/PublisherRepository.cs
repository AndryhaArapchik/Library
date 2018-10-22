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
    public class PublisherRepository : IRepository<Publisher>
    {
        private readonly LDBContext dbContext;
        public PublisherRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Publisher item)
        {
            dbContext.Publishers.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentPublisher = dbContext.Publishers.Find(id);
            if (currentPublisher != null)
                dbContext.Publishers.Remove(currentPublisher);
        }

        public IEnumerable<Publisher> Find(Func<Publisher, bool> predicate)
        {
            return dbContext.Publishers.Where(predicate).ToList();
        }

        public Publisher Get(Guid id)
        {
            return dbContext.Publishers.Find(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return dbContext.Publishers;
        }

        public void Update(Publisher item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
