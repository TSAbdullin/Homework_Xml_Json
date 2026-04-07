using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    /// <summary>
    /// Иентерфейс для сервиса игр
    /// </summary>
    public interface IGameService
    {
        /// <summary>
        /// Инициализация данных
        /// </summary>
        /// <param name="games"></param>
        public void SetData(List<Game> games);

        /// <summary>
        /// Получение списка игр
        /// </summary>
        /// <returns></returns>
        public List<GameDto> GetGames();
    }
}