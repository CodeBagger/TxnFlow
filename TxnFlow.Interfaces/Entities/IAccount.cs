using TxnFlow.Interfaces.Business_Rules;

namespace TxnFlow.Interfaces.Entities
{
    public interface IAccount
    {
        decimal PostTransaction(ITransaction transaction);
        void CloseAccount();
    }
}