using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.DTO
{
    public class PlayerDto
    {
        public string? Username { get; set; }
        public decimal? Balance { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Country { get; set; }
        public DateTime? Birthday { get; set; }
        public string? LastGameName { get; set; }
    }
}