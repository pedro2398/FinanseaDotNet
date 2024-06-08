using FinanseaAPI.Context;
using FinanseaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinanseaAPI.Service;
public class ProjectService
{
    private readonly FinanseaContext _context;

    public ProjectService(FinanseaContext context)
    {
        _context = context;
    }

    public async Task<List<Project>> FindAll()
    {
        var list = await _context.Project
            .ToListAsync();

        return list;
    }

    public async Task<Project> FindById(long id)
    {
        var entity = await FindEntityById(id);
        return entity;
    }

    public async Task<Project> Create(Project entity)
    {
        _context.Project.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Project> Update(long id, Project updatedData)
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
        _context.Project.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Project> FindEntityById(long id)
    {
        var entity = await _context.Project
            .FirstOrDefaultAsync(x => x.id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Object not found with ID: {id}");
        }
        return entity;
    }

}