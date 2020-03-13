using System;

namespace TxnFlow.Infrastructure
{
    public class SaveException : Exception
    {
        public SaveException(string message):base(message)
        {
        }
    }
}