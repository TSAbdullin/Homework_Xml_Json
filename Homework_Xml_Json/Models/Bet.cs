using Homework_Xml_Json.Enums;
using System;

namespace Homework_Xml_Json.Models
{
    /// <summary>
    /// Модель ставки
    /// </summary>
    public class Bet
    {
        /// <summary>
        /// Идентификатор ставки
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Дата ставки
        /// </summary>
        public DateTime Date {  get; set; }

        /// <summary>
        /// Результат ставки
        /// </summary>
        public BetResult BetResult { get; set; }

        /// <summary>
        /// Данные игрока, поставившего ставку
        /// </summary>
        public Player? Player { get; set; }

        /// <summary>
        /// Данные об игре, в которой поставлена ставка
        /// </summary>
        public Game? Game { get; set; }
    }
}