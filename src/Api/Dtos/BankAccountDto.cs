using System.Linq.Expressions;
using Domain.Models;

namespace Api.Dtos;

public class BankAccountDto
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public decimal AccountBalance { get; set; }

    public static Expression<Func<BankAccount, BankAccountDto>> FromBankAccount =>
        bankAccount => new BankAccountDto
        {
            Id = bankAccount.Id,
            AccountNumber = bankAccount.AccountNumber,
            AccountBalance = bankAccount.AccountBalance
        };
}