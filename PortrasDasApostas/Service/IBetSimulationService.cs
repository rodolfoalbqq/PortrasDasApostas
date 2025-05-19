using PortrasDasApostas.Models;
using System.Threading.Tasks;

namespace PortrasDasApostas.Services
{
    public interface IBetSimulationService
    {
        Task<SimulationResult> SimulateBetAsync(Bet bet);
        Task<EducationalInfo> GetEducationalInfoAsync();
    }
}