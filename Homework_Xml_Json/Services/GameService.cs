using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
    public class GameService : IGameService
    {
        private List<Game> _games = new();

        public void SetData(List<Game> games)
        {
            _games = games ?? new List<Game>();
        }

        public List<GameDto> GetGames()
        {
            return _games.Select(x => new GameDto
            {
                Name = x.Name,
                GameType = x.GameType,
                MinBet = x.MinBet,
                MaxBet = x.MaxBet
            }).ToList();
        }
    }
}
