using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreWebApp.Controllers
{
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public IActionResult GetGames()
        {
            return Ok(_gameService.GetAll());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (string id)
        {
            if (_gameService.GetById(id) == null)
                return NotFound();
            _gameService.Delete(id);

            return NoContent();
        }

        //[HttpPost]
        //public IActionResult CreateGame()

        [HttpGet("{id}")]
        public IActionResult GetGameDetails(string id)
        {
            return Ok(_gameService.GetById(id));
        }


    }
}
