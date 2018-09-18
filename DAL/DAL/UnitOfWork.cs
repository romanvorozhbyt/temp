using DAL.Abstarction;
using DAL.EF;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly GameStoreContext _context;

        private IRepository<Game> _gameRepository;
        private readonly Lazy<IRepository<Genre>> _genreRepository;
        private readonly Lazy<IRepository<Publisher>> _publisherRepository;
        private readonly Lazy<IRepository<Comment>> _commentRepository;
        private readonly Lazy<IRepository<PlatformType>> _platformRepository;

        //public IRepository<Game> Games => _gameRepository.Value;

        public IRepository<Genre> Genres => _genreRepository.Value;

        public IRepository<Publisher> Publishers => _publisherRepository.Value;

        public IRepository<Comment> Comments => _commentRepository.Value;

        public IRepository<PlatformType> Platforms => _platformRepository.Value;

        public IRepository<Game> Games => _gameRepository ?? (_gameRepository = new Repository<Game>(_context));


        public UnitOfWork (DbContextOptions<GameStoreContext> options)
        {
            _context = new GameStoreContext(options);

            //_gameRepository = new Lazy<IRepository<Game>>(() => new Repository<Game>(_context));
            _genreRepository = new Lazy<IRepository<Genre>>(() => new Repository<Genre>(_context));
            _publisherRepository = new Lazy<IRepository<Publisher>>(() => new Repository<Publisher>(_context));
            _platformRepository = new Lazy<IRepository<PlatformType>>(() => new Repository<PlatformType>(_context));
            _commentRepository = new Lazy<IRepository<Comment>>(() => new Repository<Comment>(_context));
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Save() => _context.SaveChanges();
        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                    (Repository<Game>)Games.Delete(])
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
