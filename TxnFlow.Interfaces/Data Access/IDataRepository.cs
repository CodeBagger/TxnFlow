using System.Collections.Generic;

namespace TxnFlow.Interfaces.Data_Access
{
    public interface IDataRepository<TEntity>
    {
        //TEntity CreateNew();

        void Delete(TEntity item);
        void Update(TEntity item);
        TEntity Insert(TEntity item);

        IEnumerable<TEntity> FindAll();
        TEntity FindOne(int id);
    }
}
