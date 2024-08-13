using Tools.Context;

namespace Tools.UnitOfWork;

public class UnitOfWork(MyDbContext context) : IUnitOfWork
{
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}