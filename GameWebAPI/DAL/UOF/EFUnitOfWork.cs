using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories;

namespace DAL.UOF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private GameContext db;
        private EFGenericRepository<Game> GameRepository;
        private EFGenericRepository<Genre> GenreRepository;
        private EFGenericRepository<Publisher> PublisherRepository;
        private EFGenericRepository<PlatformType> PlatformTypeRepository;
        private EFGenericRepository<Comment> CommentRepository;


        public EFUnitOfWork(string connectionString)
        {
            db = new GameContext();
        }
        public IGenericRepository<Game> Games
        {
            get
            {
                if (GameRepository == null)
                    GameRepository = new EFGenericRepository<Game>(db);
                return GameRepository;
            }
        }
        public IGenericRepository<Genre> Genres
        {
            get
            {
                if (GenreRepository == null)
                    GenreRepository = new EFGenericRepository<Genre>(db);
                return GenreRepository;
            }
        }
        public IGenericRepository<Publisher> Publishers
        {
            get
            {
                if (PublisherRepository == null)
                    PublisherRepository = new EFGenericRepository<Publisher>(db);
                return PublisherRepository;
            }
        }
        public IGenericRepository<PlatformType> PlatformTypes
        {
            get
            {
                if (PlatformTypeRepository == null)
                    PlatformTypeRepository = new EFGenericRepository<PlatformType>(db);
                return PlatformTypeRepository;
            }
        }
        public IGenericRepository<Comment> Comments
        {
            get
            {
                if (CommentRepository == null)
                    CommentRepository = new EFGenericRepository<Comment>(db);
                return CommentRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
