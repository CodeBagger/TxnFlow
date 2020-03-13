using System;
using System.Collections.Generic;
using TxnFlow.Interfaces.Rules;

namespace TxnFlow.Logic.RuleSet
{
    public class DeletePersonRules : IDeletePersonRules
    {
        private List<IRule> _rules;

        public DeletePersonRules()
        {
            _rules = new List<IRule>();
        }
        public RuleResult ValidateAllRules()
        {
            var messages = new List<string>();
            var result = Result.Success;
            foreach (var rule in _rules)
            {
                if (!rule.Validate())
                {
                    result = Result.Fail;
                    messages.Add(rule.FailureMessage);
                }
            }
            return new RuleResult(result,string.Join(Environment.NewLine,messages));
        }

        public void AddRule(IRule rule)
        {
            _rules.Add(rule);
        }
    }
}