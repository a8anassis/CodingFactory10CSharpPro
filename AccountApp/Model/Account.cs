
using AccountApp.Exceptions;

namespace AccountApp.Model;

internal class Account
{
    public int Id { get; set; }
    public string? Iban { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Ssn { get; set; }
    public decimal Balance { get; set; }

    // Public API

    /// <summary>
    /// Deposits the specified amount into the account.
    /// The amount must be greater than zero. 
    /// If the amount is less than or equal to zero, an exception is thrown.
    /// </summary>
    /// <param name="amount">The amount to deposit.</param>
    public void Deposit(decimal amount)
    {
        try
        {
            if (amount < 0)
            {
                throw new NegativeAmountException("Deposit amount cannot be negative.");
            }
            Balance += amount;
            // Log the successful deposit
        }
        catch (NegativeAmountException ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");        // Logging the error message to the console
            throw;                                                  // Rethrow the exception to be handled by the caller
        }
    }

    /// <summary>
    /// Withdraws the specified amount from the account if the provided SSN matches the account holder's SSN.
    /// </summary>
    /// <param name="amount">The amount to withdraw.</param>
    /// <param name="ssn">The SSN of the account holder.</param>
    /// <exception cref="InvalidSsnException">If the provided SSN does not match the account holder's SSN.</exception>
    /// <exception cref="NegativeAmountException">If the withdrawal amount is negative.</exception>
    /// <exception cref="InsufficientBalanceException">If there are insufficient funds for the withdrawal.</exception>
    public void Withdraw(decimal amount, string? ssn)
    {
        try
        {
            if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException("SSN cannot be null or empty.");
            if (ssn != Ssn) throw new InvalidSsnException("SSN does not match the account holder's SSN.");
            if (amount < 0) throw new NegativeAmountException("Withdrawal amount cannot be negative.");
            if (amount > Balance) throw new InsufficientBalanceException("Insufficient funds for withdrawal.");

            Balance -= amount;
            // Log the successful withdrawal
        }
        catch (Exception ex) when (ex is InvalidSsnException 
                                    or NegativeAmountException 
                                    or InsufficientBalanceException)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

}
