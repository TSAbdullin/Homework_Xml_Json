using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Enums;
using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
    /// <summary>
    /// Сервис для работы с аналитикой
    /// </summary>
    public class AnalyticsService : IAnalyticsService
    {
        private readonly IBetService _betService;

        public AnalyticsService(IBetService betService)
        {
            _betService = betService;
        }

        /// <summary>
        /// Получить список игроков для топа
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public List<TopPlayerDto> GetTopPlayers(int amount)
        {
            var bets = _betService.GetBets();

            return bets
                .GroupBy(x => x.PlayerUsername)
                .Select(x => new
                {
                    Name = x.Key,
                    Total = x.Sum(x => x.Amount)
                })
                .OrderByDescending(x => x.Total)
                .Take(amount)
                .Select((x, index) => new TopPlayerDto
                {
                    Rank = index + 1,
                    Name = x.Name,
                    TotalAmount = x.Total
                })
                .ToList();
        }

        /// <summary>
        /// Получить итоговую сумму всех ставок всех пользователей
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalAmount()
        {
            var bets = _betService.GetBets();

            return bets.Sum(x => x.Amount);
        }

        /// <summary>
        /// Получить процент побед всех пользователей
        /// </summary>
        /// <returns></returns>
        public double GetWinRateBet()
        {
            var bets = _betService.GetBets();
            var wins = bets.Count(x => x.BetResult == BetResult.Win);

            return Math.Round((double)wins / bets.Count() * 100, 2);
        }

        /// <summary>
        /// Получить самую популярную игру среди всех пользователей
        /// </summary>
        /// <returns></returns>
        public string GetMostPopularGame()
        {
            var bets = _betService.GetBets();

            var topGame = bets
                .GroupBy(x => x.GameName)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            if (topGame is null)
            {
                return "None";
            }

            return topGame.Key;
        }
    }
}