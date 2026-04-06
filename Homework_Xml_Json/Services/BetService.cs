using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
    public class BetService : IBetService
    {
        private List<Bet> _bets = new();

        public void SetData(List<Bet> bets)
        {
            _bets = bets ?? new List<Bet>();
        }

        public List<BetDto> GetBets()
        {
            return _bets.Select(x => new BetDto
            {
                Amount = x.Amount,
                Date = x.Date,
                BetResult = x.BetResult,
                PlayerUsername = x.Player?.Username,
                GameName = x.Game?.Name
            }).ToList();
        }
    }
}
