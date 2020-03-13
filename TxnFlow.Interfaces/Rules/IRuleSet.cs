namespace TxnFlow.Interfaces.Rules
{
    public interface IRuleSet
    {
        RuleResult ValidateAllRules();
        void AddRule(IRule rule);
    }
}