using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxnFlow.Interfaces.Entities;

namespace TxnFlow.Data
{
    public class PersonEntity : IPerson
    {
        public ICollection<IAccount> Accounts
        {

            get;set;
        }

        
        public int code
        {
            get;set;
        }

        
        public string id_number
        {
            get;set;
        }

        
        public bool IsSaved
        {
            get;
        }

        
        public string name
        {
            get;set;
        }

        
        public string surname
        {
            get;set;
        }
    }
}
