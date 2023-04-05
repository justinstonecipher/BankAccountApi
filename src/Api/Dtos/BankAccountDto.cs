using Domain.Models;

namespace Api.Dtos
{
    public class BankAccountDto
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }

        protected BankAccountDto FromBankAccount(BankAccount model)
        {
            return new BankAccountDto
            {
                Id = model.Id,
                AccountNumber = model.AccountNumber,
                AccountBalance = model.AccountBalance
            };
        }
    }
}
