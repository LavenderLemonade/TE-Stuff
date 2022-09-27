namespace BankTellerExercise.Classes
{
    public class CheckingAccount: BankAccount
    {

        public CheckingAccount(): base()
        {

        }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }


        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw < 0.00M && Balance - amountToWithdraw > -100.00M)
            {
                return Balance -= (10.00M + amountToWithdraw);
            }
            else if ((Balance - amountToWithdraw) < 0.00M && (Balance - amountToWithdraw) <= -100.00M)
            {
                System.Console.WriteLine("Transaction Failed: Balance too low.");
                return Balance;
            }
            else if ((Balance - amountToWithdraw) > 0.00M)
            {
                return Balance -= amountToWithdraw;
            }
            return 0;
        }
    }
}
