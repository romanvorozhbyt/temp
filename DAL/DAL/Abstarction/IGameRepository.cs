using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstarction
{
    public interface IGameRepository
    {
        void Insert(Game game);

        void Update(Game game);

        Task<Game> GetByKeyAsync(string key);

        Task<IEnumerable<Game>> GetAllAsync();

        void Delete(int id);
    }
}
