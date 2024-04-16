using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserLoginPrac.Areas.Identity.Data;
using UserLoginPrac.Models;

namespace UserLoginPrac.Data;

public class UserLoginPracContext : IdentityDbContext<UserLoginPracUser>
{
    public UserLoginPracContext(DbContextOptions<UserLoginPracContext> options)
        : base(options)
    {
    }

    DbSet<UserLoginPracUser> Users {  get; set; }
    DbSet<Account> accounts {  get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<UserLoginPrac.Models.Account> Account { get; set; } = default!;
}
