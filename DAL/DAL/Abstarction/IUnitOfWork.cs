using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstarction
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<IGameRepository> Games { get; }
        IRepository<IGenreRepository> Genres { get; }
        IRepository<IPublisherRepository> Publishers { get; }
        IRepository<ICommentRepository> Comments { get; }
        IRepository<IPlatformRepository> Platforms { get; }
        Task SaveAsync();
        void Save();

    }
}
