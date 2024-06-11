using CleanAchictecture.Domain.Common;
using CleanAchictecture.Persistence.DatabaseContexts;
using CleanAchitecture.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanAchictecture.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly MsSqlDatabaseContext _context;

        public GenericRepository(MsSqlDatabaseContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
            _ = await _context.AddAsync(entity);
            _ = await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _ = _context.Remove(entity);
            _ = await _context.SaveChangesAsync();
        }
        public async Task DeleteRangeAsync(List<T> entity)
        {
            _context.RemoveRange(entity);
            _ = await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync()
        {
            return await _context.Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await _context.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(q => q.Id == Id);
        }

        public async Task UpdateAsync(T entity)
        {
            _ = _context.Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _ = await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<T> entity)
        {
            _context.UpdateRange(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _ = await _context.SaveChangesAsync();
        }
    }
}
