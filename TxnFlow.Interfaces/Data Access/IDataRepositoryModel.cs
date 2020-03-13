using System.Collections.Generic;
using TxnFlow.Interfaces.Entities;

namespace TxnFlow.Interfaces.Data_Access
{
    public interface IDataRepositoryModel
    {
         IEnumerable<IPerson> GetAllPeople();
         IPerson Find(int id);
         void Delete(IPerson person);
    }
}
