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
    public class FeedbackRepository : IRepository<Feedback>
    {
        private readonly LDBContext dbContext;
        public FeedbackRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Feedback item)
        {
            dbContext.Reviews.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentFeedback = dbContext.Reviews.Find(id);
            if (currentFeedback != null)
                dbContext.Reviews.Remove(currentFeedback);
        }

        public IEnumerable<Feedback> Find(Func<Feedback, bool> predicate)
        {
            return dbContext.Reviews.Where(predicate).ToList();
        }

        public Feedback Get(Guid id)
        {
            return dbContext.Reviews.Find(id);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return dbContext.Reviews;
        }

        public void Update(Feedback item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
