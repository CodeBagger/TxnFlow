using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxnFlow.Interfaces.Business_Rules;
using TxnFlow.Interfaces.Rules;

namespace TxnFlow.Logic.RuleSet
{
    public class SavePersonRules : ISavePersonRules
    {
        private List<IRule> _rules;
        public SavePersonRules()
        {
            _rules = new List<IRule>();
        }

        public void AddRule(IRule rule)
        {
            _rules.Add(rule);
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
            return new RuleResult(result, string.Join(Environment.NewLine, messages));
        }
    }
}
