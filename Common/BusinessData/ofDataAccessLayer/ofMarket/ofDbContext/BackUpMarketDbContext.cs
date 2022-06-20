using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofDbContext
{
    public class BackUpMarketDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpMarketDbContext(DbContextOptions<MarketDbContext> options)
            : base(options)
        {

        }
        public BackUpMarketDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.MarketDbConnection; }
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
        public DbSet<PlatMarket> PlatMarkets { get; set; }
    }
}