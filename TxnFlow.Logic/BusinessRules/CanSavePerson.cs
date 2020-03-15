using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxnFlow.Data;
using TxnFlow.Interfaces.Data_Access;
using TxnFlow.Interfaces.Entities;
using TxnFlow.Interfaces.Rules;

namespace TxnFlow.Logic.BusinessRules
{
    public class CanSavePerson : IRule
    {
        IPerson _person;
        public CanSavePerson(IPerson person)
        {
            _person = person;
            FailureMessage = "";
        }
        public string FailureMessage
        {
            get;set;
        }

        public bool Validate()
        {
            IPerson _alreadyExistingPerson;
            IDataRepositoryModel DRM = new DataRepositoryModel();
            _alreadyExistingPerson = DRM.FindByIdNumber(_person.id_number);
            if (_alreadyExistingPerson != null)
            {
                FailureMessage = "Person Already Exists";
                return false;
                
                
            }
            return true;
        }
    }
}
