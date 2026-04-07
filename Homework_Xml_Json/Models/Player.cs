using System;

namespace Homework_Xml_Json.Models
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Username пользователя
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Баланс
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Данные о профиле пользователя
        /// </summary>
        public Profile? Profile { get; set; }

        /// <summary>
        /// Данные о прошлой сыгранной игре
        /// </summary>
        public Game? LastGame { get; set; }
    }
}