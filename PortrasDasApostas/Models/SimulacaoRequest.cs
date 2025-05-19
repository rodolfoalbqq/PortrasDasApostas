using PortrasDasApostas.Enums;

namespace PortrasDasApostas.Models
{
    public class SimulacaoRequest
    {
        public decimal Valor { get; set; }
        public decimal Odds { get; set; }
        public BetType Tipo { get; set; }
    }
}