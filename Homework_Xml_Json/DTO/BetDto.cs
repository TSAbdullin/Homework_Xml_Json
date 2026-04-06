using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.DTO
{
    public class BetDto
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public BetResult BetResult { get; set; }

        public string? PlayerUsername { get; set; }

        public string? GameName { get; set; }
    }
}
