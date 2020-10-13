using System;

namespace InvestmentPerformance.WebApi.Entities
{
    public class Investment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal CurrentPrice { get; set; }
    }
}
