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
    public class UserRepository : IRepository<User>
    {
        private readonly LDBContext dbContext;
        public UserRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(User item)
        {
            dbContext.Users.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentUser = dbContext.Users.Find(id);
            if (currentUser != null)
                dbContext.Users.Remove(currentUser);
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return dbContext.Users.Where(predicate).ToList();
        }

        public User Get(Guid id)
        {
            return dbContext.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return dbContext.Users;
        }

        public void Update(User item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
