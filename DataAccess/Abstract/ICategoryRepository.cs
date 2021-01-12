using Repository_Pattern.Entity;

namespace Repository_Pattern.DataAccess.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category[] GetCategories();
    }
}