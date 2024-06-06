using CleanAchictecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanAchictecture.Persistence.DatabaseContexts
{
    public class MsSqlDatabaseContext : DbContext
    {
        public MsSqlDatabaseContext(DbContextOptions<MsSqlDatabaseContext> options) : base(options)
        { }

        //------------------Newly Added By Oladayo Ale-------------------------
        public DbSet<User> Users { get; set; }
    }
}
