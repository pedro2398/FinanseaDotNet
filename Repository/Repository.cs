using FinanseaAPI.Context;

namespace FinanseaAPI.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        protected FinanseaContext _finaseaContext;

        public Repository(FinanseaContext finanseaContext)
        {
            _finaseaContext = finanseaContext;
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _finaseaContext.Set<TEntity>().ToList();
        }

        public TEntity FindById(long id)
        {
            return _finaseaContext.Set<TEntity>().Find(id);
        }

        public void Create(TEntity entity)
        {
            _finaseaContext.Set<TEntity>().Add(entity);
            _finaseaContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _finaseaContext.Set<TEntity>().Update(entity);
            _finaseaContext.SaveChanges();
        }

        public void Delete(long id)
        {
            var entity = FindById(id);
            _finaseaContext.Set<TEntity>().Remove(entity);
            _finaseaContext.SaveChanges();
        }
    }
}