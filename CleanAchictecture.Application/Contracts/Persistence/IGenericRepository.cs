using CleanAchictecture.Domain.Common;

namespace CleanAchitecture.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateRangeAsync(List<T> entity);
        Task DeleteRangeAsync(List<T> entity);
    }
}
