using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.DTO
{
    /// <summary>
    /// Класс для передачи данных о пользователе (Player, Profile)
    /// </summary>
    public class PlayerDto
    {
        /// <summary>
        /// Username пользователя 
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Баланс
        /// </summary>
        public decimal? Balance { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Название последней сыгранной игры
        /// </summary>
        public string? LastGameName { get; set; }
    }
}