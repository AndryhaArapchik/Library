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
    public class LanguageRepository : IRepository<Language>
    {
        private readonly LDBContext dbContext;
        public LanguageRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Language item)
        {
            dbContext.Languages.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentLanguage = dbContext.Languages.Find(id);
            if (currentLanguage != null)
                dbContext.Languages.Remove(currentLanguage);
        }

        public IEnumerable<Language> Find(Func<Language, bool> predicate)
        {
            return dbContext.Languages.Where(predicate).ToList();
        }

        public Language Get(Guid id)
        {
            return dbContext.Languages.Find(id);
        }

        public IEnumerable<Language> GetAll()
        {
            return dbContext.Languages;
        }

        public void Update(Language item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
