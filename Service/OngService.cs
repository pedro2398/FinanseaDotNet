using FinanseaAPI.Context;
using FinanseaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinanseaAPI.Service;
public class OngService
{
    private readonly FinanseaContext _context;

    public OngService(FinanseaContext context)
    {
        _context = context;
    }

    public async Task<List<Ong>> FindAll()
    {
        var list = await _context.Ong
            .ToListAsync();

        return list;
    }

    public async Task<Ong> FindById(long id)
    {
        var entity = await FindEntityById(id);
        return entity;
    }

    public async Task<Ong> Create(Ong entity)
    {
        _context.Ong.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Ong> Update(long id, Ong updatedData)
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
        _context.Ong.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Ong> FindEntityById(long id)
    {
        var entity = await _context.Ong
            .FirstOrDefaultAsync(x => x.id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Object not found with ID: {id}");
        }
        return entity;
    }

}