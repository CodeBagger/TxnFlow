using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TxnFlow.Data;
using TxnFlow.Interfaces.DataAccess;

namespace TxnFlow.Implementations
{
    public class DataRepositoryModel : IDataRepositoryModel
    {
        public IEnumerable<Person> GetAllPeople()
        {
            TxnFlowDBEntities _db = new TxnFlowDBEntities();
            DataRepository<Person> DR = new DataRepository<Person>(_db);
            return DR.FindAll();
        }
    }
}