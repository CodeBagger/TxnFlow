using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxnFlow.Interfaces.Entities;
using TxnFlow.Interfaces.Rules;

namespace TxnFlow.Logic.BusinessRules
{
    public class CanDeletePerson : IRule
    {
        private readonly IPerson _person;
        private string _failureMessage;
        private CanDeletePerson() { }
        public CanDeletePerson(IPerson person)
        {
            _person = person;
        }

        public bool Validate()
        {
            var accountsCount = _person.Accounts.Count;
            var validate = accountsCount == 0;
            if (!validate)
            {
                _failureMessage =
                    $"Person {_person.name} still has {accountsCount} linked. Please remove all accounts before deleting.";
            }
            return validate;
        }

        public string FailureMessage => _failureMessage;
    }
}
