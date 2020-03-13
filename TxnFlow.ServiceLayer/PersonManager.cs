using System;
using TxnFlow.Infrastructure;
using TxnFlow.Interfaces.Business_Rules;
using TxnFlow.Interfaces.Data_Access;
using TxnFlow.Interfaces.Entities;
using TxnFlow.Interfaces.Rules;

namespace TxnFlow.ServiceLayer
{
    public class PersonManager
    {
        public IPerson AddPerson(IPerson person, IDataRepository<IPerson> personRepository,ISavePersonRules saveRules)
        {
            var validateAllRules = saveRules.ValidateAllRules();
            if (validateAllRules.Result == Result.Success)
            {
                return personRepository.Insert(person);
            }

            throw new SaveException($"Error saving Person. Message: {validateAllRules.Message}");
        }

        public RuleResult DeletePerson(IPerson person, IDataRepositoryModel personRepository, IDeletePersonRules deleteRules)
        {
            var validateAllRules = deleteRules.ValidateAllRules();
            if (validateAllRules.Result == Result.Success)
            {
                try
                {
                    personRepository.Delete(person);
                }
                catch (Exception ex)
                {
                    return new RuleResult(Result.Fail, ex.Message);
                }
            }

            return validateAllRules;
        }
    }
}
