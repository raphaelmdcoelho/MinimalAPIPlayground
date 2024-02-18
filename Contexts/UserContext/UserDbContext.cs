using Microsoft.EntityFrameworkCore;
using MinimalApiPlayground.Modes;

namespace MinimalApiPlayground.Contexts.UserContext;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(m => m.Id);
        modelBuilder.Entity<User>().Property(m => m.FirstName).IsRequired();
        modelBuilder.Entity<User>().Property(m => m.FirstName).IsRequired();

        base.OnModelCreating(modelBuilder);
    }
}