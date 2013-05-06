using EFDemo.Model;

namespace EFDemo.DAL.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        string GetUrl();
    }
}
