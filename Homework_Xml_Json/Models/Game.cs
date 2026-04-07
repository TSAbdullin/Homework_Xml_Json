using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.Models
{
    /// <summary>
    /// Модель игры
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Идентификатор игры
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Тип игры
        /// </summary>
        public GameType GameType { get; set; }

        /// <summary>
        /// Минимальная ставка
        /// </summary>
        public decimal MinBet { get; set; }

        /// <summary>
        /// Максимальная ставка
        /// </summary>
        public decimal MaxBet { get; set; }
    }
}