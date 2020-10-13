using InvestmentPerformance.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvestmentPerformance.WebApi.Services
{
    public interface IGetInvestments
    {
        /// <summary>
        /// Get investments for specified user.
        /// </summary>
        Task<IEnumerable<Investment>> GetInvestmentsAsync(int userId);
    }
}
