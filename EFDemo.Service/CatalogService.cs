using System;
using System.Collections.Generic;
using System.Linq;
using EFDemo.DAL.Structures;
using EFDemo.Model;

namespace EFDemo.Service
{
    public class CatalogService : Interfaces.ICatalogService, IDisposable
    {
        private IDALContext context;

        public CatalogService(IDALContext dal)
        {
            context = dal;
        }

        public List<Category> GetCategories()
        {
            return context.Categories.All().ToList();
        }

        public List<Product> GetProducts()
        {
            return context.Products.All().ToList();
        }

        public Product CreateProduct(string categoryName, string productName, int price)
        {
            var category = new Category() { Name = categoryName };
            var product = new Product() { Name = productName, Price = price, Category = category };
            context.Products.Create(product);
            context.SaveChanges();
            return product;
        }

        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}
