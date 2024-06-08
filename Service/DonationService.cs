using FinanseaAPI.Context;
using FinanseaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinanseaAPI.Service;
public class DonationService
{
    private readonly FinanseaContext _context;

    public DonationService(FinanseaContext context)
    {
        _context = context;
    }

    public async Task<List<Donation>> FindAll()
    {
        var list = await _context.Donation
            .ToListAsync();

        return list;
    }

    public async Task<Donation> FindById(long id)
    {
        var entity = await FindEntityById(id);
        return entity;
    }

    public async Task<Donation> Create(Donation entity)
    {
        _context.Donation.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Donation> Update(long id, Donation updatedData)
    {
        var entity = await FindEntityById(id);
        updatedData.id = entity.id;
        _context.Entry(entity).CurrentValues.SetValues(updatedData);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(long id)
    {
        var entity = await FindEntityById(id);
        _context.Donation.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Donation> FindEntityById(long id)
    {
        var entity = await _context.Donation
            .FirstOrDefaultAsync(x => x.id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Object not found with ID: {id}");
        }
        return entity;
    }

}