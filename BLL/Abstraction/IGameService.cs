using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstraction
{
    public interface IGameService
    {
        void CreateGame(GameDTO game);
        void EditGame(GameDTO game);
        void DeleteGame(string id);
        GameDTO GetGameById(string id);
        IEnumerable<GameDTO> GetAllGames();
    }
}
