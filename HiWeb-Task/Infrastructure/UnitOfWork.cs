using HiWeb_Task.Application.Interfaces;

namespace HiWeb_Task.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> CommitAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}