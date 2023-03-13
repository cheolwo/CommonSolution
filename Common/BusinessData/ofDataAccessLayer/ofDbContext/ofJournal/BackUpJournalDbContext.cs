using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofJournal
{
    public class BackUpJournalDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpJournalDbContext(DbContextOptions<JournalDbContext> options)
            : base(options)
        {

        }
        public BackUpJournalDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JournalCenterConfiguration());
            modelBuilder.ApplyConfiguration(new JCommodityConfiguration());
        }
    }
}

