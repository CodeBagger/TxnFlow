using System;

namespace TxnFlow.Infrastructure
{
    public class DeleteException : Exception
    {
        public DeleteException(string message):base(message)
        {
        }
    }
}