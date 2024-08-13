namespace Tools.UnitOfWork;

public interface IUnitOfWork
{
    Task CompleteAsync();
}