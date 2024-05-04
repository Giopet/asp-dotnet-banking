using Microsoft.EntityFrameworkCore;

namespace Banking.API.Models;

public class BankingContext : DbContext
{
    public BankingContext(DbContextOptions<BankingContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasMany(p => p.Accounts)
            .WithOne(a => a.Person)
            .HasForeignKey(a => a.PersonId);

        modelBuilder.Seed();
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Person> People { get; set; }
}
