using CleanAchictecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanAchictecture.Persistence.DatabaseContexts
{
    public class OracleDatabaseContext : DbContext
    {
        public OracleDatabaseContext(DbContextOptions<OracleDatabaseContext> options) : base(options)
        { }

        //------------------Newly Added By Oladayo Ale-------------------------
        public DbSet<User> Users { get; set; }
    }
}
