using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxnFlow.Interfaces.Entities;

namespace TxnFlow.Interfaces.Data_Access
{
    public interface IDataRepositoryModel
    {
        IEnumerable<IPerson> GetAllPeople();
        IPerson Find(int id);
        IPerson FindByIdNumber(string idnumber);
        void Delete(IPerson person);
        IPerson Add();
        IPerson Create(IPerson person);
    }
}
