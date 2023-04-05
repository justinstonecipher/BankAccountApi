using Domain.Models;

namespace Domain.Interfaces;

public interface IBankAccountService
{
    Task<BankAccount> GetBankAccountAsync(string accountNumber);
}