using System;
namespace Homework_Xml_Json.Models
{
    public class DataContainer
    {
        public List<Game>? Games { get; set; }
        public List<Player>? Players { get; set; }
        public List<Bet>? Bets { get; set; }
    }
}
