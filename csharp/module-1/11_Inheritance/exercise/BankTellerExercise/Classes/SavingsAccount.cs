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
            if (amountToWithdraw > Balance || (amountToWithdraw + 2) > Balance)
            {
                System.Console.WriteLine("Transaction failed.");
                return Balance;
            }
            else if (Balance - (amountToWithdraw + 2.0M) == 0)
            {
                return Balance -= (amountToWithdraw + 2.0M);
            }
            else if (Balance - (amountToWithdraw + 2.0M) < 150.0M && Balance - (amountToWithdraw + 2.0M) >= 0)
            {
                return Balance -= (amountToWithdraw + 2.0M);
            }
            else
            {
                return Balance -= amountToWithdraw;
            }
            
        }
    }
}
