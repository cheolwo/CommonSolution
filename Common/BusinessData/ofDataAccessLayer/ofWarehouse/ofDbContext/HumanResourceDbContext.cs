using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext
{
    public class WHumanResourceDbContext : IdentityDbContext
    {
        public WHumanResourceDbContext(DbContextOptions<WHumanResourceDbContext> option)
                : base(option)
        {

        }
    }
}
