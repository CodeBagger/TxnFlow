namespace TxnFlow.Interfaces.Rules
{
    public struct RuleResult
    {
        public RuleResult(Result result, string message)
        {
            Result = result;
            Message = message;
        }

        public string Message { get; }
        public Result Result { get; }
    }
}