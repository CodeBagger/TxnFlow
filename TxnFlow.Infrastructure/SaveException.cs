using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxnFlow.Infrastructure
{
    public class SaveException : Exception
    {
        public SaveException(string message) : base(message)
        {
        }
    }
}
