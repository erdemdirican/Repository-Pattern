using Repository_Pattern.Entity;

namespace Repository_Pattern.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product[] GetProductsByCategory(int id);
        Product[] GetPopularProducts();
    }
}