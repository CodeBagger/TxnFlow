using System.Collections.Generic;
using TxnFlow.Interfaces.Data_Access;
using TxnFlow.Interfaces.Entities;

namespace TxnFlow.Data
{
    public class DataRepositoryModel : IDataRepositoryModel
    {
        public IEnumerable<IPerson> GetAllPeople()
        {
            var context = new TxnFlowDBEntities();
            var repo = new DataRepository<IPerson>(context);
            return repo.FindAll();
        }

        public IPerson Find(int id)
        {
            var context = new TxnFlowDBEntities();
            var repo = new DataRepository<IPerson>(context);
            return repo.FindOne(id);
        }

        public void Delete(IPerson person)
        {
            var context = new TxnFlowDBEntities();
            var repo = new DataRepository<IPerson>(context);
            repo.Delete(person);
        }
    }
}