using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxnFlow.Interfaces.Entities
{
    public interface IAccount
    {
        decimal PostTransaction(ITransaction transaction);
        void CloseAccount();
    }
}
