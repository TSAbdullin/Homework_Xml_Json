using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
    /// <summary>
    /// Сервис для работы с пользователями
    /// </summary>
    public class PlayerService : IPlayerService
    {
        private List<Player> _players = new();

        /// <summary>
        /// Инициализирует внутреннюю коллекцию пользователей
        /// </summary>
        /// <param name="players"></param>
        public void SetData(List<Player> players)
        {
            _players = players ?? new List<Player>();
        }

        /// <summary>
        /// Получает список пользователей
        /// </summary>
        /// <returns></returns>
        public List<PlayerDto> GetPlayers()
        {
            return _players.Select(x => new PlayerDto
            {
                Username = x.Username,
                FirstName = x.Profile?.FirstName,
                LastName = x.Profile?.LastName,
                Balance = x.Balance,
                Country = x.Profile?.Country,
                Birthday = x.Profile?.Birthday,
                LastGameName = x.LastGame?.Name
            }).ToList();
        }
    }
}