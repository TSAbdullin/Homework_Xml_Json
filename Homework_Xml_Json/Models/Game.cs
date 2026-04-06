using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        
        public string? Name { get; set; }

        public GameType GameType { get; set; }

        public decimal MinBet { get; set; }

        public decimal MaxBet { get; set; }
    }
}