using InvestmentPerformance.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentPerformance.WebApi.Services
{
    public class InvestmentService : IGetInvestments
    {
        private readonly InvestmentPerformanceContext _context;

        public InvestmentService(InvestmentPerformanceContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get investments for specified user.
        /// </summary>
        public async Task<IEnumerable<Investment>> GetInvestmentsAsync(int userId)
        {
            var user = await _context.Users.Include(u => u.Investments).ThenInclude(ui => ui.Investment).SingleOrDefaultAsync(u => u.Id == userId);

            return user?.Investments.Select(ui => new Investment()
            {
                Id = ui.Investment.Id,
                Name = ui.Investment.Name,
            });
        }
    }
}
