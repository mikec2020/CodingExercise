using InvestmentPerformance.WebApi.Models;
using System.Threading.Tasks;

namespace InvestmentPerformance.WebApi.Services
{
    public interface IGetInvestmentDetails
    {
        /// <summary>
        /// Get investment details for specified user and investment.
        /// </summary>
        Task<InvestmentDetails> GetInvestmentDetailsAsync(int userId, int investmentId);
    }
}
