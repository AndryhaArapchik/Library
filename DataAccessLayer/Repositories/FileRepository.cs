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
    public class FileRepository : IRepository<File>
    {
        private readonly LDBContext dbContext;
        public FileRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(File item)
        {
            dbContext.Files.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentFile = dbContext.Files.Find(id);
            if (currentFile != null)
                dbContext.Files.Remove(currentFile);
        }

        public IEnumerable<File> Find(Func<File, bool> predicate)
        {
            return dbContext.Files.Where(predicate).ToList();
        }

        public File Get(Guid id)
        {
            return dbContext.Files.Find(id);
        }

        public IEnumerable<File> GetAll()
        {
            return dbContext.Files;
        }

        public void Update(File item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
