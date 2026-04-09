using System;

namespace Homework_Xml_Json.DTO
{
    /// <summary>
    /// DTO для отображения топа игроков по сумме ставок
    /// </summary>
    public class TopPlayerDto
    {
        /// <summary>
        /// Место в рейтинге
        /// </summary>
        public long Rank { get; set; }

        /// <summary>
        /// Имя игрока
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Общая сумма ставок игрока
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}