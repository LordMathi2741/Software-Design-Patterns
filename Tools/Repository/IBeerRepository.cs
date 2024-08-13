using Tools.Models;

namespace Tools.Repository;

public interface IBeerRepository
{
    Task <IEnumerable<Beer>> GetAllAsync();
    Task<Beer?> GetByIdAsync(int id);
    Task AddAsync(Beer beer);
    
    Task DeleteAsync(Beer beer);
    Task UpdateAsync(Beer beer);
    
}