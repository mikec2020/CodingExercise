﻿using InvestmentPerformance.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentPerformance.WebApi.Mappings
{
    public class InvestmentMap : IEntityTypeConfiguration<Investment>
    {
        public void Configure(EntityTypeBuilder<Investment> builder)
        {
            builder.ToTable("Investments", "dbo");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).HasColumnName("InvestmentId");
        }
    }
}
