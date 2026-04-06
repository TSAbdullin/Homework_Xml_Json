using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.DTO
{
    public class DataDto
    {
        public List<Game>? Games { get; set; }
        public List<Player>? Players { get; set; }
        public List<Bet>? Bets { get; set; }
    }
}
