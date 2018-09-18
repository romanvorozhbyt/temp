using DAL.Abstarction;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    class GameRepository : IGameRepository
    {
        private readonly GameStoreContext _db;
        private readonly DbSet<Game> _dbSet;
        public GameRepository(GameStoreContext context)
        {
            _db = context;
            _dbSet = context.Set<Game>();
        }
       
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        
        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        
        public async Task<Game> GetByKeyAsync(string key)
        {
            return await _dbSet.LastOrDefaultAsync(g=>g.Key == key);
        }

        public void Insert(Game game)
        {
            if (game == null)
                throw new ArgumentNullException(nameof(game));

            if (_dbSet.Find(game.Id) == null)
                _dbSet.Add(game);
        }

        public void Update(Game game)
        {
            var itemToModify = _dbSet.Find(game.Id);
            if (itemToModify == null)
                throw new ArgumentException(nameof(game));
            _db.Entry(itemToModify).CurrentValues.SetValues(game);
            _db.Entry(itemToModify).State = EntityState.Modified;
        }
    }
}
