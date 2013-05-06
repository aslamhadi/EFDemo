using EFDemo.Model;

namespace EFDemo.DAL.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        string ResolvePictures();
    }
}
