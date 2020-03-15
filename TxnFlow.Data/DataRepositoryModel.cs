using System;
using System.Collections.Generic;
using TxnFlow.Interfaces.Data_Access;
using TxnFlow.Interfaces.Entities;
using System.Linq;

namespace TxnFlow.Data
{
    public class DataRepositoryModel : IDataRepositoryModel
    {
        public IEnumerable<IPerson> GetAllPeople()
        {
            var context = new TxnFlowDBEntities();
            var repo = new DataRepository<Person>(context);
            IEnumerable<Person> ReturnedList = new List<Person>();
            List<PersonEntity> PersonList = new List<PersonEntity>();

            ReturnedList = repo.FindAll();

            foreach (Person P in ReturnedList)
            {
                PersonEntity CurrentPerson = new PersonEntity();
                CurrentPerson.code = P.code;
                CurrentPerson.id_number = P.id_number;
                CurrentPerson.name = P.name;
                CurrentPerson.surname = P.surname;
                PersonList.Add(CurrentPerson);
            }
            
            return PersonList;
           
        }

        public IPerson Add()
        {
            IPerson PersonEntity = new PersonEntity();
            return PersonEntity;
        }

        public IPerson Find(int id)
        {
            var context = new TxnFlowDBEntities();
            var repo = new DataRepository<Person>(context);
            Person P = repo.FindOne(id);
            PersonEntity FoundPerson = new PersonEntity();
            FoundPerson.code = P.code;
            FoundPerson.name = P.name;
            FoundPerson.surname = P.surname;
            FoundPerson.id_number = P.id_number;
            return FoundPerson;
        }

        public void Delete(IPerson person)
        {
            var context = new TxnFlowDBEntities();
            var repo = new DataRepository<IPerson>(context);
            repo.Delete(person);
        }

        public IPerson Create(IPerson person)
        {
            var context = new TxnFlowDBEntities();
            Person P = new Person();
            P.code = person.code;
            P.name = person.name;
            P.id_number = person.id_number;
            P.surname = person.surname;
            var repo = new DataRepository<Person>(context);
            repo.Insert(P);
            return person;
            
        }

        public IPerson FindByIdNumber(string idnumber)
        {
            var context = new TxnFlowDBEntities();
            var repo = new DataRepository<Person>(context);
            Person P = context.Persons.Where(s =>s.id_number == idnumber).FirstOrDefault();
            PersonEntity FoundPerson = new PersonEntity();
            FoundPerson.code = P.code;
            FoundPerson.name = P.name;
            FoundPerson.surname = P.surname;
            FoundPerson.id_number = P.id_number;
            return FoundPerson;
        }
    }
}
