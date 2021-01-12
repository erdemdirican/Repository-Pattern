using System;
using Repository_Pattern.DataAccess.Abstract;
using Repository_Pattern.Entity;

namespace Repository_Pattern.DataAccess.Concrete
{
    public class MySQLProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            Console.WriteLine("MySQLProduct - create");
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}