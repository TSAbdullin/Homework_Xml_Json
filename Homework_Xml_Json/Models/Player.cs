using System;

namespace Homework_Xml_Json.Models
{
    public class Player
    {
        public Guid Id { get; set; }

        public string? Username { get; set; }

        public decimal Balance { get; set; }

        public Profile? Profile { get; set; }

        public Game? LastGame { get; set; }
    }
}