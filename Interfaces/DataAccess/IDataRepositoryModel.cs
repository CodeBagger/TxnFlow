using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxnFlow.Data;

namespace TxnFlow.Interfaces.DataAccess
{
    public interface IDataRepositoryModel
    {
         IEnumerable<Person> GetAllPeople();
    }
}
