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
        IPerson _person;
        CanDeletePerson(IPerson person)
        {
            _person = person;
        }
        public string FailureMessage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
