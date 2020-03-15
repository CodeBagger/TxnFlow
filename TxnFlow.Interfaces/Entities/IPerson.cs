using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxnFlow.Interfaces.Entities
{
    public interface IPerson
    {
        int code { get; set; }
        string name { get; set; }
        string surname { get; set; }
        string id_number { get; set; }


        bool IsSaved { get; }
        ICollection<IAccount> Accounts { get; set; }
    }

   
}
