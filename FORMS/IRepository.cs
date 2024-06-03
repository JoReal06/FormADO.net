namespace FORMS
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll(TEntity entity);
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);



    }
}
