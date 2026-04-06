using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.Models
{
    public class Bet
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date {  get; set; }

        public BetResult BetResult { get; set; }

        public Player? Player { get; set; }

        public Game? Game { get; set; }
    }
}