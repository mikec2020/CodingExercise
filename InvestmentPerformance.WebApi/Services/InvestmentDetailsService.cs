﻿using InvestmentPerformance.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InvestmentPerformance.WebApi.Services
{
    public class InvestmentDetailsService : IGetInvestmentDetails
    {
        private readonly InvestmentPerformanceContext _context;

        public InvestmentDetailsService(InvestmentPerformanceContext context)
        {
            _context = context;
        }

        public async Task<InvestmentDetails> GetInvestmentDetailsAsync(int userId, int investmentId)
        {
            var userInvestment = await _context.UserInvestments.Include(ui => ui.Investment)
                .SingleOrDefaultAsync(ui => ui.UserId == userId && ui.InvestmentId == investmentId);

            if (userInvestment == null)
            {
                return null;
            }
            else
            {
                return new InvestmentDetails()
                {
                    CostBasis = userInvestment.CostBasis,
                    CurrentPrice = userInvestment.Investment.CurrentPrice,
                    DatePurchased = userInvestment.DatePurchased,
                    Shares = userInvestment.Shares,
                };
            }
        }
    }
}
