using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    public interface IBetService
    {
        public void SetData(List<Bet> bets);
        public List<BetDto> GetBets();
    }
}
