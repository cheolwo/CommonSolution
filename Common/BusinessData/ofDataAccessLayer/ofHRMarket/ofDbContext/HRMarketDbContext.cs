using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofHRMarket.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofHRMarket.ofDbContext
{
    // 고용계약 DB
    public class HRMarketDbContext : DbContext
    {
        public HRMarketDbContext(DbContextOptions<HRMarketDbContext> options)
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

    public class HRMarketConfigration : CenterConfiguration<HRMarket>
    {
        public override void Configure(EntityTypeBuilder<HRMarket> builder)
        {
            base.Configure(builder);
        }
    }
    public class JobOfferConfigration : EntityConfiguration<JobOffer>
    {
        public override void Configure(EntityTypeBuilder<JobOffer> builder)
        {
            base.Configure(builder);
        }
    }
    public class EmployeeMessageConfigration : EntityConfiguration<EmployeeMessage>
    {
        public override void Configure(EntityTypeBuilder<EmployeeMessage> builder)
        {
            base.Configure(builder);
        }
    }
}
