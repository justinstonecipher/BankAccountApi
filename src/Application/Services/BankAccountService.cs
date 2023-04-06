using Domain.Interfaces;
using Domain.Models;
using Infrastructure;

namespace Application.Services;

public class BankAccountService : IBankAccountService
{
    private readonly BankDbContext _dbContext;

    public BankAccountService(BankDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<BankAccount> GetBankAccountAsync(string accountNumber)
    {
        throw new NotImplementedException();
    }
}