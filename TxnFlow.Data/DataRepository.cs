using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TxnFlow.Interfaces.Data_Access;

namespace TxnFlow.Data
{
    public class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> _dbSet;
        private TxnFlowDBEntities _dbContext;
        public DataRepository(TxnFlowDBEntities dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Delete(TEntity item)
        {
            _dbSet.Remove(item);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _dbSet.ToList();
        }

        public TEntity FindOne(int id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Insert(TEntity item)
        {
            return _dbSet.Add(item);
        }

        public void Update(TEntity item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}