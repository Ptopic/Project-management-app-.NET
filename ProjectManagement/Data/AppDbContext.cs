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

        var admin = new IdentityRole("admin");
        admin.NormalizedName = "admin";
        
        var manager = new IdentityRole("manager");
        admin.NormalizedName = "manager";
        
        var user = new IdentityRole("user");
        admin.NormalizedName = "user";

        builder.Entity<IdentityRole>().HasData(admin, manager, user);
    }
}