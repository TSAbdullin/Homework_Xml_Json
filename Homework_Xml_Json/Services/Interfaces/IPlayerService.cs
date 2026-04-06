using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    public interface IPlayerService
    {
        public void SetData(List<Player> players);
        public List<PlayerDto> GetPlayers();
    }
}
