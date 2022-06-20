using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofHRMarket.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofHRMarket.ofDbContext
{
    // 고용계약 DB
    public class BackUpHRMarketDbContext : DbContext
    {
        public BackUpHRMarketDbContext(DbContextOptions<HRMarketDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HRMarketConfigration());
            builder.ApplyConfiguration(new JobOfferConfigration());
            builder.ApplyConfiguration(new EmployeeMessageConfigration());
        }
    }
}
