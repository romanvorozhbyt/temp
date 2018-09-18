using DAL.Abstarction;
using DAL.EF;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DAL
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly GameStoreContext _context;

        private readonly Lazy<IRepository<IGameRepository>> _gameRepository;
        private readonly Lazy<IRepository<IGenreRepository>> _genreRepository;
        private readonly Lazy<IRepository<IPublisherRepository>> _publisherRepository;
        private readonly Lazy<IRepository<ICommentRepository>> _commentRepository;
        private readonly Lazy<IRepository<IPlatformRepository>> _platformRepository;

        public IRepository<IGameRepository> Games => _gameRepository.Value;

        public IRepository<IGenreRepository> Genres => _genreRepository.Value;

        public IRepository<IPublisherRepository> Publishers => _publisherRepository.Value;

        public IRepository<ICommentRepository> Comments => _commentRepository.Value;

        public IRepository<IPlatformRepository> Platforms => _platformRepository.Value;

        public UnitOfWork (DbContextOptions<GameStoreContext> options)
        {
            _context = new GameStoreContext(options);

            _gameRepository = new Lazy<IRepository<IGameRepository>>(() => new Repository<GameRepository>(_context));
            _genreRepository = new Lazy<IRepository<IGenreRepository>>(() => new GenreRepository(_context));
            _publisherRepository = new Lazy<IRepository<IPublisherRepository>>(() => new PublisherRepository(_context));
            _platformRepository = new Lazy<IRepository<IPlatformRepository>>(() => new PlatformRepository(_context));
            _commentRepository = new Lazy<IRepository<ICommentRepository>>(() => new CommentRepository(_context));

        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Save() => _context.SaveChanges();

        public void Dispose()
        {
            _context.SaveChanges(); 

        }
    }
}
