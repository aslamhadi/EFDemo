namespace EFDemo.DAL.Structures
{
    public interface IDALContext : IUnitOfWork
    {
        Interfaces.ICategoryRepository Categories { get; }
        Interfaces.IProductRepository Products { get; }
    }
}
