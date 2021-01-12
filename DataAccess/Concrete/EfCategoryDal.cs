using Repository_Pattern.DataAccess.Abstract;
using Repository_Pattern.Entity;

namespace Repository_Pattern.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public void Create(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category[] GetCategories()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}