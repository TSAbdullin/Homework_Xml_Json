using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса пользователей
    /// </summary>
    public interface IPlayerService
    {
        /// <summary>
        /// Инициализация данных
        /// </summary>
        /// <param name="players"></param>
        public void SetData(List<Player> players);

        /// <summary>
        /// Получение списка пользователей
        /// </summary>
        /// <returns></returns>
        public List<PlayerDto> GetPlayers();
    }
}