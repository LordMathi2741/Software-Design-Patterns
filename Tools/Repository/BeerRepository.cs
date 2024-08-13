using Microsoft.EntityFrameworkCore;
using Tools.Context;
using Tools.Models;
using Tools.UnitOfWork;

namespace Tools.Repository;

public class BeerRepository : IBeerRepository
{
    private readonly MyDbContext _context;
    private readonly IUnitOfWork _unitOfWork;
    public BeerRepository(MyDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }
    public async Task<IEnumerable<Beer>> GetAllAsync()
    {
        return await _context.Beers.ToListAsync();
    }

    public async Task<Beer?> GetByIdAsync(int id)
    {
        return await _context.Beers.FindAsync(id);
    }

    public async Task AddAsync(Beer beer)
    {
        await _context.Beers.AddAsync(beer);
        await _unitOfWork.CompleteAsync();
    }

    public async Task DeleteAsync(Beer beer)
    {
        var beerToDelete = await _context.Beers.FindAsync(beer.Id);
        if (beerToDelete != null) _context.Beers.Remove(beerToDelete);
        await _unitOfWork.CompleteAsync();
    }

    public async Task UpdateAsync(Beer beer)
    {
        var beerToUpdate = await _context.Beers.FindAsync(beer.Id);
        if (beerToUpdate != null) _context.Beers.Update(beerToUpdate);
        await _unitOfWork.CompleteAsync();
    }

}