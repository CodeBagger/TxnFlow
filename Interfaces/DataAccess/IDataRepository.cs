using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxnFlow.Data;
using TxnFlow.Interfaces.DataAccess;

namespace TxnFlow.Interfaces.DataAccess
{
    public interface IDataRepository<TEntity>
    {
        //TEntity CreateNew();

        void Delete(TEntity item);
        void Update(TEntity item);
        void Insert(TEntity item);

        IEnumerable<TEntity> FindAll();
        TEntity FindOne(int id);
    }

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

        public void Insert(TEntity item)
        {
            _dbSet.Add(item);
        }

        public void Update(TEntity item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
