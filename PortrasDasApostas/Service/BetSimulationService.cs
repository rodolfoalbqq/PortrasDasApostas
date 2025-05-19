using PortrasDasApostas.Models;
using System;
using System.Threading.Tasks;

namespace PortrasDasApostas.Services
{
    public class BetSimulationService : IBetSimulationService
    {
        private readonly Random _random;
        private const decimal HOUSE_EDGE = 0.05m; // Vantagem da casa de 5%

        public BetSimulationService()
        {
            _random = new Random();
        }

        public async Task<SimulationResult> SimulateBetAsync(Bet bet)
        {
            var realProbability = 1 / bet.Odds;
            var adjustedProbability = realProbability * (1 - HOUSE_EDGE);
            var isWin = _random.NextDouble() < (double)adjustedProbability;

            var educationalMessage = isWin
                ? $"Você ganhou desta vez! Mas saiba que a casa tem uma vantagem de {HOUSE_EDGE * 100}% em cada aposta."
                : "Esta perda demonstra como as odds são calculadas para favorecer a casa. A probabilidade real era menor do que parecia.";

            return new SimulationResult
            {
                IsWin = isWin,
                RealProbability = realProbability,
                HouseEdge = HOUSE_EDGE,
                EducationalMessage = educationalMessage,
                ActualOdds = bet.Odds * (1 - HOUSE_EDGE),
                DisplayedOdds = bet.Odds
            };
        }

        public async Task<EducationalInfo> GetEducationalInfoAsync()
        {
            return new EducationalInfo
            {
                HouseEdgeExplanation = "A casa sempre tem uma vantagem matemática em cada aposta.",
                OddsExplanation = "As odds mostradas são sempre mais atraentes que a probabilidade real.",
                PsychologicalTricks = new[]
                {
                    "Luzes e sons são projetados para estimular dopamina",
                    "Ganhos pequenos são mais frequentes para manter o jogador apostando",
                    "Perdas são minimizadas visualmente para reduzir o impacto psicológico"
                }
            };
        }
    }
}