using CleanAchictecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanAchictecture.Persistence.DatabaseContexts
{
    public class MySqlDatabaseContext : DbContext
    {
        public MySqlDatabaseContext(DbContextOptions<MySqlDatabaseContext> options) : base(options)
        { }

        //------------------Newly Added By Oladayo Ale-------------------------
        public DbSet<User> Users { get; set; }
    }
}
