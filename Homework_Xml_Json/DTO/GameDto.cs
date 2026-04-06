using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.DTO
{
    public class GameDto
    {
        public string? Name { get; set; }
        public GameType GameType { get; set; }
        public decimal MinBet { get; set; }
        public decimal MaxBet { get; set; }
    }
}