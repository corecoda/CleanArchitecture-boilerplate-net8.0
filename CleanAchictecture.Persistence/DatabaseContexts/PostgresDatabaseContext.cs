using CleanAchictecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanAchictecture.Persistence.DatabaseContexts
{
    public class PostgresDatabaseContext : DbContext
    {
        public PostgresDatabaseContext(DbContextOptions<OracleDatabaseContext> options) : base(options)
        { }

        //------------------Newly Added By Oladayo Ale-------------------------
        public DbSet<User> Users { get; set; }
    }
}
