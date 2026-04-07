using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
    /// <summary>
    /// Сервис для работы с играми
    /// </summary>
    public class GameService : IGameService
    {
        private List<Game> _games = new();

        /// <summary>
        /// Инициализирует внутреннюю коллекцию игр
        /// </summary>
        /// <param name="games"></param>
        public void SetData(List<Game> games)
        {
            _games = games ?? new List<Game>();
        }

        /// <summary>
        /// Получение всех игр
        /// </summary>
        /// <returns></returns>
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