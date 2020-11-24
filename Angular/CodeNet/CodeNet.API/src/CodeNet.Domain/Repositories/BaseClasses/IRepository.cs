namespace CodeNet.Domain.Repositories.BaseClasses
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}