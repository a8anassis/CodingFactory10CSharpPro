using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account()
            {
                Id = 1,
                Iban = "GR123456789",
                Firstname = "Athanassios",
                Lastname = "Androutsos",
                Ssn = "123-45-6789",
                Balance = 1000.00m
            };


            try
            {
                account.Deposit(50m);
                Console.WriteLine($"Deposit OK. New balance: {account.Balance}");

                account.Withdraw(30m, "123-45-6789");

                // Fails
                // account.Deposit(-20m);                      // NegativeAmmountException
                // account.Withdraw(100m, "12345");            // InvaliSsnException
                //account.Withdraw(10000m, "123-45-6789");   // InsufficientBalanceException 
            }
            catch (Exception ex) when (ex is NegativeAmountException
                                                or InsufficientBalanceException 
                                                or InvalidSsnException)
            {
                Console.WriteLine($"Transaction failed: {ex.GetType().Name}");
            }
        }
    }
}
