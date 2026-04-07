using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.DTO
{
    /// <summary>
    /// Класс для передачи данных модели Bet
    /// </summary>
    public class BetDto
    {
        /// <summary>
        /// Сумма ставки
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Дата ставки
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Результат ставки
        /// </summary>
        public BetResult BetResult { get; set; }

        /// <summary>
        /// Username пользователя, поставившего ставку
        /// </summary>
        public string? PlayerUsername { get; set; }

        /// <summary>
        /// Название игры
        /// </summary>
        public string? GameName { get; set; }
    }
}