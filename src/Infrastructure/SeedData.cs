using Domain.Models;

namespace Infrastructure;

public class SeedData
{
    public static void Seed(BankDbContext context)
    {
        if (!context.BankAccount.Any())
        {
            var account1 = new BankAccount { Id = 1, AccountNumber = "1234", AccountHolder = "Steve", AccountBalance = 12345.12m, DepositHistory = "Invalid Deposit History", WithdrawalHistory = "Invalid Withdrawal History" };
            var account2 = new BankAccount { Id = 2, AccountNumber = "1235", AccountHolder = "Jim Halpert", AccountBalance = 123.10m, DepositHistory = "Invalid Deposit History", WithdrawalHistory = "Invalid Withdrawal History" };

            context.BankAccount.AddRange(account1, account2);
            context.SaveChanges();
        }
    }
}