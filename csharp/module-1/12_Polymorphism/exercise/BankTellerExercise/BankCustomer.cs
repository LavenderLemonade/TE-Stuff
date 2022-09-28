using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise 
{
    class BankCustomer: IAccountable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        private SavingsAccount savings { get; set; }
        private CheckingAccount checking { get; set; }
        private CreditCardAccount credits { get; set; }

        private List<IAccountable> accountsList { get; set; }

        public decimal Balance
        {
            get
            {
                return savings.Balance + checking.Balance + credits.Balance;
            }
        }

        public bool IsVip
        {
            get
            {
                if (Balance >= 25000)
                {
                    return true;
                }
                return false;
            }
        }

        public void AddAccount(IAccountable newAccount)
        {
            accountsList.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            IAccountable[] arrayOfAccounts = new IAccountable[accountsList.Count];

            foreach(IAccountable thing in accountsList)
            {
                arrayOfAccounts[i] = thing;
            }
        }


   
  
    }
}
