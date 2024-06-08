using FinanseaAPI.Context;
using FinanseaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinanseaAPI.Service;
public class PublicationService
{
    private readonly FinanseaContext _context;

    public PublicationService(FinanseaContext context)
    {
        _context = context;
    }

    public async Task<List<Publication>> FindAll()
    {
        var list = await _context.Publication
            .ToListAsync();

        return list;
    }

    public async Task<Publication> FindById(long id)
    {
        var entity = await FindEntityById(id);
        return entity;
    }

    public async Task<Publication> Create(Publication entity)
    {
        _context.Publication.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Publication> Update(long id, Publication updatedData)
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
        _context.Publication.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Publication> FindEntityById(long id)
    {
        var entity = await _context.Publication
            .FirstOrDefaultAsync(x => x.id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Object not found with ID: {id}");
        }
        return entity;
    }

}