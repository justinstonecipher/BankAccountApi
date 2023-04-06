using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BankDbContext : DbContext
{
    public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
    {
    }
    public DbSet<BankAccount> BankAccount { get; set; }
}