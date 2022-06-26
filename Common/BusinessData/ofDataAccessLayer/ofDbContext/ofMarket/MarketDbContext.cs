using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofDbContext
{
    public class MarketDbContext : DbContext
    {
        private string _connectionstring;
        public MarketDbContext(DbContextOptions<MarketDbContext> options)
            : base(options)
        {

        }
        public MarketDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.MarketDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarketConfiguration());
            modelBuilder.ApplyConfiguration(new MCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SMCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MMCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EMCommodityConfiguration());
        }
        public DbSet<PlatMarket> PlatMarkets {get; set;}
    }
    public class MCommodityConfiguration : CommodityConfiguration<MCommodity>
    {
        public override void Configure(EntityTypeBuilder<MCommodity> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Options).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Option>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.ToTable("MCommodity"); 
        }
    }
    public class MarketConfiguration : CenterConfiguration<Market>
    {
        public override void Configure(EntityTypeBuilder<Market> builder)
        {
            base.Configure(builder);
            builder.ToTable("Market");
        }
    }
    public class SMCommodityConfiguration : StatusConfiguration<SMCommodity>
    {
        public override void Configure(EntityTypeBuilder<SMCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("SPCommodity");
        }
    }
    public class MMCommodityConfiguration : StatusConfiguration<MMCommodity>
    {
        public override void Configure(EntityTypeBuilder<MMCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("MMCommodity");
        }
    }
    public class EMCommodityConfiguration : StatusConfiguration<EMCommodity>
    {
        public override void Configure(EntityTypeBuilder<EMCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("EMCommodity");
        }
    }
}