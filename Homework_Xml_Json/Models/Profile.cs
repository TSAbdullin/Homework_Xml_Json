using System;

namespace Homework_Xml_Json.Models
{
    /// <summary>
    /// Модель профиля пользователя
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string? Country { get; set; }
    }
}