using FinanseaAPI.Context;
using FinanseaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinanseaAPI.Service;
public class FinancierService
{
    private readonly FinanseaContext _context;

    public FinancierService(FinanseaContext context)
    {
        _context = context;
    }

    public async Task<List<Financier>> FindAll()
    {
        var list = await _context.Financier
            .ToListAsync();

        return list;
    }

    public async Task<Financier> FindById(long id)
    {
        var entity = await FindEntityById(id);
        return entity;
    }

    public async Task<Financier> Create(Financier entity)
    {
        _context.Financier.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Financier> Update(long id, Financier updatedData)
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
        _context.Financier.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Financier> FindEntityById(long id)
    {
        var entity = await _context.Financier
            .FirstOrDefaultAsync(x => x.id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Object not found with ID: {id}");
        }
        return entity;
    }

}