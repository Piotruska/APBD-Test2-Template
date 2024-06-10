

using Test2Template.DataBase.Context;

namespace Test2Template.Api.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly MyContext _context;

    public UnitOfWork(MyContext context)
    {
        _context = context;
    }

    public async Task BeginTransactionAsync()
    {
        await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        await _context.Database.CommitTransactionAsync();
    }

    public async Task RollbackTransactionAsync()
    {
        await _context.Database.RollbackTransactionAsync();
    }
}