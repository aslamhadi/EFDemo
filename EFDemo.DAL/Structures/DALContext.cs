using System;
using EFDemo.DAL.Interfaces;

namespace EFDemo.DAL.Structures
{
    public class DALContext : IDALContext
    {
        private Db dbContext;
        private ICategoryRepository categories;
        private IProductRepository products;

        public DALContext()
        {
            dbContext = new Db();
        }

        public ICategoryRepository Categories
        {
            get
            {
                if (categories == null)
                    categories = new CategoryRepository(dbContext);
                return categories;
            }
        }

        public IProductRepository Products
        {
            get
            {
                if (products == null)
                    products = new ProductRepository(dbContext);
                return products;
            }
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (categories != null)
                categories.Dispose();
            if (products != null)
                products.Dispose();
            if (dbContext != null)
                dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
