using System;

namespace Homework_Xml_Json.Models
{
    /// <summary>
    /// Класс, содержащий все данные приложения
    /// </summary>
    public class AppData
    {
        /// <summary>
        /// Все игры
        /// </summary>
        public List<Game>? Games { get; set; }

        /// <summary>
        /// Все игроки
        /// </summary>
        public List<Player>? Players { get; set; }

        /// <summary>
        /// Все ставки
        /// </summary>
        public List<Bet>? Bets { get; set; }
    }
}