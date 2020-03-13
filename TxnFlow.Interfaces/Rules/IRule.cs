namespace TxnFlow.Interfaces.Rules
{
    public interface IRule
    {
        bool Validate();
        string FailureMessage { get; }
    }
}