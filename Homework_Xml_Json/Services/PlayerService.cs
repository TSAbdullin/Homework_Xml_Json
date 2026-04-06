using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
    public class PlayerService : IPlayerService
    {
        private List<Player> _players = new();

        public void SetData(List<Player> players)
        {
            _players = players ?? new List<Player>();
        }

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
