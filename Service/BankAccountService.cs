using FinanseaAPI.Context;
using FinanseaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinanseaAPI.Service;
public class BankAccountService
{
    private readonly FinanseaContext _context;

    public BankAccountService(FinanseaContext context)
    {
        _context = context;
    }

    public async Task<List<BankAccount>> FindAll()
    {
        var list = await _context.BankAccount
            .ToListAsync();

        return list;
    }

    public async Task<BankAccount> FindById(long id)
    {
        var entity = await FindEntityById(id);
        return entity;
    }

    public async Task<BankAccount> Create(BankAccount entity)
    {
        _context.BankAccount.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<BankAccount> Update(long id, BankAccount updatedData)
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
        _context.BankAccount.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<BankAccount> FindEntityById(long id)
    {
        var entity = await _context.BankAccount
            .FirstOrDefaultAsync(x => x.id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Object not found with ID: {id}");
        }
        return entity;
    }

}