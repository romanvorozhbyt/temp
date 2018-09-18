using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Abstarction
{
    public interface IUnitOfWork 
    {
        IRepository<Game> Games { get; }
        IRepository<Genre> Genres { get; }
        IRepository<Publisher> Publishers { get; }
        IRepository<Comment> Comments { get; }
        IRepository<PlatformType> Platforms { get; }
        Task SaveAsync();
        void Save();

    }
}
