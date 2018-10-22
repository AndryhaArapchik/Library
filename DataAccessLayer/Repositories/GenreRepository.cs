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
    public class GenreRepository : IRepository<Genre>
    {
        private readonly LDBContext dbContext;
        public GenreRepository(LDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Genre item)
        {
            dbContext.Genres.Add(item);
        }

        public void Delete(Guid id)
        {
            var currentGenre = dbContext.Genres.Find(id);
            if (currentGenre != null)
                dbContext.Genres.Remove(currentGenre);
        }

        public IEnumerable<Genre> Find(Func<Genre, bool> predicate)
        {
            return dbContext.Genres.Where(predicate).ToList();
        }

        public Genre Get(Guid id)
        {
            return dbContext.Genres.Find(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return dbContext.Genres;
        }

        public void Update(Genre item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
