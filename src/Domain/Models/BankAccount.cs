using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class BankAccount
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public string AccountHolder { get; set; }
    [Column(TypeName = "decimal(16,4)")]
    public decimal AccountBalance { get; set; }
    public string DepositHistory { get; set; }
    public string WithdrawalHistory { get; set; }
}