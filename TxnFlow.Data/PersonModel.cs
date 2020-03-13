using System;
using System.Collections.Generic;
using TxnFlow.Interfaces.Entities;

namespace TxnFlow.Data
{
    class PersonModel : IPerson
    {
        public int code
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string id_number
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSaved { get; }
        public IList<IAccount> Accounts { get; }

        public string name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string surname
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}