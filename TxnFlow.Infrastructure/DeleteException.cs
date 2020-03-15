using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxnFlow.Infrastructure
{
    public class DeleteException : Exception
    {
        public DeleteException(string message) : base(message)
        {
        }
    }
}
