using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class BankAccountApiDbContext : DbContext
    {
        public BankAccountApiDbContext(DbContextOptions<BankAccountApiDbContext> options) : base(options)
        {
        }
        public DbSet<BankAccount> BankAccount { get; set; }
    }

}