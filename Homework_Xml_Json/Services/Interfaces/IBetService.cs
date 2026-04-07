using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса ставок
    /// </summary>
    public interface IBetService
    {
        /// <summary>
        /// Инициализация данных
        /// </summary>
        /// <param name="bets"></param>
        public void SetData(List<Bet> bets);

        /// <summary>
        /// Получение списка ставок
        /// </summary>
        /// <returns></returns>
        public List<BetDto> GetBets();
    }
}