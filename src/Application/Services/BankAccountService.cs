using Domain.Interfaces;
using Domain.Models;
using Infrastructure;

namespace Application.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly BankAccountApiDbContext _dbContext;

        public BankAccountService(BankAccountApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<BankAccount> GetBankAccount(string bankAccountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
