using Domain.Models;

namespace Domain.Interfaces
{
    public interface IBankAccountService
    {
        Task<BankAccount> GetBankAccount(string bankAccountNumber);
    }
}
