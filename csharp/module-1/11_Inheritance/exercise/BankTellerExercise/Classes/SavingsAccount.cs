namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {

        public SavingsAccount(): base()
        {

        }

        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) :base(accountHolderName,accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > Balance)
            {
                System.Console.WriteLine("Transaction failed.");
                return Balance;
            }
            else if (amountToWithdraw <= Balance && Balance < 150.00M)
            {
                return Balance -= (2.00M + amountToWithdraw);
            }
            return 0;
        }
    }
}
