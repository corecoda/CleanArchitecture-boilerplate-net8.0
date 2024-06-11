using CleanAchictecture.Domain.Entities;
using CleanAchictecture.Persistence.DatabaseContexts;
using CleanAchictecture.Persistence.Repositories;
using CleanAchitecture.Application.Contracts.Persistence;

namespace CleanAchitecture.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(MsSqlDatabaseContext context) : base(context)
        {
        }
    }
}
