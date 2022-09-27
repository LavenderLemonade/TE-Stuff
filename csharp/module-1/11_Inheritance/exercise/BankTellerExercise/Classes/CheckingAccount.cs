namespace BankTellerExercise.Classes
{
    public class CheckingAccount: BankAccount
    {

        public CheckingAccount(): base()
        {

        }


        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw <0.00M && Balance - amountToWithdraw > -100.00M)
            {
                return Balance -= 10.00M;
            }
            else if ((Balance - amountToWithdraw) < 0.00M && (Balance - amountToWithdraw) <= -100.00M)
            {
                System.Console.WriteLine("Transaction Failed: Balance too low.");
                return Balance;
            }
            return 0;
        }
    }
}
