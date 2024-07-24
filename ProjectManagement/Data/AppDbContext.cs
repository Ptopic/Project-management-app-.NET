using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;

namespace ProjectManagement.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var admin = new IdentityRole("Admin");
        admin.NormalizedName = "ADMIN";
        
        var manager = new IdentityRole("Manager");
        manager.NormalizedName = "MANAGER";
        
        var user = new IdentityRole("User");
        user.NormalizedName = "USER";

        builder.Entity<IdentityRole>().HasData(admin, manager, user);
    }
}