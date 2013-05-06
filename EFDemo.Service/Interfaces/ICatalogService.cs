using System.Collections.Generic;
using EFDemo.Model;

namespace EFDemo.Service.Interfaces
{
    public interface ICatalogService
    {
        List<Category> GetCategories();
        List<Product> GetProducts();
        Product CreateProduct(string categoryName, string productName, int price);
    }
}
