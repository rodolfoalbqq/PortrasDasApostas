namespace PortrasDasApostas.Models
{
    public class SimulationResult
    {
        public bool IsWin { get; set; }
        public decimal RealProbability { get; set; }
        public decimal HouseEdge { get; set; }
        public string EducationalMessage { get; set; }
        public decimal ActualOdds { get; set; }
        public decimal DisplayedOdds { get; set; }
    }
}