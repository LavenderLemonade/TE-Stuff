using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise 
{
    class BankCustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
<<<<<<< HEAD

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
=======
        private List<IAccountable> accountsList { get; set; } = new List<IAccountable>();
 
>>>>>>> cdb2576262748fc043403dd980e073badf70a92e

        public bool IsVip
        {
            get
            {
<<<<<<< HEAD
                if (this.Balance >= 25000)
=======
                decimal runningTotal = 0;
                foreach (IAccountable account in accountsList)
                {
                    runningTotal += account.Balance;
                }

                if (runningTotal >= 25000)
>>>>>>> cdb2576262748fc043403dd980e073badf70a92e
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
<<<<<<< HEAD
           return accountsList.ToArray();
=======
            
            IAccountable[] newStuff = accountsList.ToArray();
            return newStuff;

            
>>>>>>> cdb2576262748fc043403dd980e073badf70a92e
        }


   
  
    }
}
