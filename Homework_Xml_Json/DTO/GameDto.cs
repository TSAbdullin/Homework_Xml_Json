using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.DTO
{
    /// <summary>
    /// Класс для передачи данных модели Game
    /// </summary>
    public class GameDto
    {
        /// <summary>
        /// Название игры
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Тип игры
        /// </summary>
        public GameType GameType { get; set; }

        /// <summary>
        /// Минимальная ставка в игре
        /// </summary>
        public decimal MinBet { get; set; }

        /// <summary>
        /// Максимальная ставка в игре
        /// </summary>
        public decimal MaxBet { get; set; }
    }
}