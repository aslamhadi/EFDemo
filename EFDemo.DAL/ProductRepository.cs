using EFDemo.Model;

namespace EFDemo.DAL
{
    public class ProductRepository : Repository<Product>, Interfaces.IProductRepository
    {
        public ProductRepository(Db context) : base(context)
        {
        }

        public string ResolvePictures()
        {
            return string.Empty;
        }
    }
}
