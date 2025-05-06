public class BankContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }

    public BankContext(DbContextOptions<BankContext> options)
        : base(options)
    {
    }
}
