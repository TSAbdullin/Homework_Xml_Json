using Homework_Xml_Json.DTO;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса аналитики казино
    /// </summary>
    public interface IAnalyticsService
    {
        /// <summary>
        /// Получить список игроков для топа
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public List<TopPlayerDto> GetTopPlayers(int amount);

        /// <summary>
        /// Получить сумму всех ставок
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalAmount();

        /// <summary>
        /// Получить процент побед
        /// </summary>
        /// <returns></returns>
        public double GetWinRateBet();

        /// <summary>
        /// Получить популярную игру
        /// </summary>
        /// <returns></returns>
        public string GetMostPopularGame();
    }
}