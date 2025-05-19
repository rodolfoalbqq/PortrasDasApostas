using PortrasDasApostas.Core.Enums;
using System;

namespace PortrasDasApostas.Models
{
    public class Bet
    {
        public Guid Id { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Odds { get; private set; }
        public BetType Type { get; private set; }
        public BetResult Result { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public decimal PotentialWinnings { get; private set; }
        public string EducationalMessage { get; private set; }

        public Bet(decimal amount, decimal odds, BetType type)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Odds = odds;
            Type = type;
            CreatedAt = DateTime.UtcNow;
            PotentialWinnings = CalculatePotentialWinnings();
        }

        private decimal CalculatePotentialWinnings() => Amount * Odds;

        public void SetResult(BetResult result, string educationalMessage)
        {
            Result = result;
            EducationalMessage = educationalMessage;
        }
    }
}