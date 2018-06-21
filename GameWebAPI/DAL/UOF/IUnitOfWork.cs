using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories;

namespace DAL.UOF
{
   public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Game> Games { get; }
        IGenericRepository<Genre> Genres { get; }
        IGenericRepository<Publisher> Publishers { get; }
        IGenericRepository<PlatformType> PlatformTypes { get; }
        IGenericRepository<Comment> Comments { get; }
        void Save();
    }
}
