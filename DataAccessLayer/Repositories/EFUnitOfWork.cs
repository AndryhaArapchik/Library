using DataAccessLayer.Contexts;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private LDBContext dbContext;
        private AuthorRepository authorRepository;
        private BookRepository bookRepository;
        private FeedbackRepository feedbackRepository;
        private FileRepository fileRepository;
        private GenreRepository genreRepository;
        private LanguageRepository languageRepository;
        private PublisherRepository publisherRepository;
        private UserRepository userRepository;
        private bool disposed = false;
        public EFUnitOfWork(string connectionString)
        {
            dbContext = new LDBContext(connectionString);
        }

        public IRepository<Author> Authors
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(dbContext);
                return authorRepository;
            }
        }

        public IRepository<Book> Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(dbContext);
                return bookRepository;
            }
        }

        public IRepository<Feedback> Reviews
        {
            get
            {
                if (feedbackRepository == null)
                    feedbackRepository = new FeedbackRepository(dbContext);
                return feedbackRepository;
            }
        }

        public IRepository<File> Files
        {
            get
            {
                if (fileRepository == null)
                    fileRepository = new FileRepository(dbContext);
                return fileRepository;
            }
        }

        public IRepository<Genre> Genres
        {
            get
            {
                if (genreRepository == null)
                    genreRepository = new GenreRepository(dbContext);
                return genreRepository;
            }
        }

        public IRepository<Language> Languages
        {
            get
            {
                if (languageRepository == null)
                    languageRepository = new LanguageRepository(dbContext);
                return languageRepository;
            }
        }

        public IRepository<Publisher> Publishers
        {
            get
            {
                if (publisherRepository == null)
                    publisherRepository = new PublisherRepository(dbContext);
                return publisherRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(dbContext);
                return userRepository;
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
