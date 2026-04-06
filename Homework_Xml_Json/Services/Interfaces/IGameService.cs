using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    public interface IGameService
    {
        public void SetData(List<Game> games);
        public List<GameDto> GetGames();
    }
}
