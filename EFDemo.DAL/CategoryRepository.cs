using EFDemo.Model;

namespace EFDemo.DAL
{
    public class CategoryRepository : Repository<Category>, Interfaces.ICategoryRepository
    {
        public CategoryRepository(Db context) : base(context)
        {            
        }

        public string GetUrl()
        {
            return string.Empty;
        }
    }
}
