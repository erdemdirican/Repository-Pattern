namespace Repository_Pattern.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);
    }
}