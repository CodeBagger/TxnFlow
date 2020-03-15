using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxnFlow.Interfaces.Data_Access
{
    public interface IDataRepository<TEntity>
    {
        //TEntity CreateNew();

        void Delete(TEntity item);
        void Update(TEntity item);
        TEntity Insert(TEntity item);

        IEnumerable<TEntity> FindAll();
        TEntity FindOne(int code);
    }
}
