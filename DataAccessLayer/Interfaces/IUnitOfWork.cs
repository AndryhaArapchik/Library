using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Author> Authors { get; }
        IRepository<Book> Books { get; }
        IRepository<Feedback> Reviews { get; }
        IRepository<File> Files { get; }
        IRepository<Genre> Genres { get; }
        IRepository<Language> Languages { get; }
        IRepository<Publisher> Publishers { get; }
        IRepository<User> Users { get; }
        void Save();
    }
}
