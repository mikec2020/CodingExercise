using InvestmentPerformance.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentPerformance.WebApi.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "dbo");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("UserId");
            builder.HasMany(u => u.Investments);
        }
    }
}
