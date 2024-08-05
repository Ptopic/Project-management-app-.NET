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
    
    public DbSet<Project> Projects { get; set; }
    public DbSet<TaskDefinition> TasksDefinitions { get; set; }
    public DbSet<Team> Teams { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<Team>()
            .HasMany(t => t.Members)
            .WithOne(u => u.Team)
            .OnDelete(DeleteBehavior.SetNull);

        var admin = new IdentityRole("Admin");
        admin.NormalizedName = "ADMIN";
        
        var manager = new IdentityRole("Manager");
        manager.NormalizedName = "MANAGER";
        
        var user = new IdentityRole("User");
        user.NormalizedName = "USER";

        builder.Entity<IdentityRole>().HasData(admin, manager, user);

        PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        
        var admin1 = new User
        {
            Id = "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
            UserName = "admin1",
            NormalizedUserName = "ADMIN1",
            Email = "admin@gmail.com",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            FirstName = "Admin",
            LastName = "Admin",
        };
        admin1.PasswordHash = passwordHasher.HashPassword(admin1, "Petar123$");

        var manager1 = new User
        {
            Id = "95fd4abd-0626-49fd-956c-19438402a603",
            UserName = "manager1",
            NormalizedUserName = "MANAGER1",
            Email = "manager@gmail.com",
            NormalizedEmail = "MANAGER@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            FirstName = "Manager",
            LastName = "Manager",
        };
        manager1.PasswordHash = passwordHasher.HashPassword(manager1, "Petar123$");

        var manager2 = new User
        {
            Id = "1f7ec708-e841-4ab2-846f-05c24fa18301",
            UserName = "manager2",
            NormalizedUserName = "MANAGER2",
            Email = "petar.topic@blankhq.co",
            NormalizedEmail = "PETAR.TOPIC@BLANKHQ.CO",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            FirstName = "Manager2",
            LastName = "Manager2",
        };
        manager2.PasswordHash = passwordHasher.HashPassword(manager2, "Petar123$");

        var user1 = new User
        {
            Id = "e58ea87d-6a8f-49e0-939c-20d89f995574",
            UserName = "user1",
            NormalizedUserName = "USER1",
            Email = "petartopic2002@gmail.com",
            NormalizedEmail = "PETARTOPIC2002@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            FirstName = "User",
            LastName = "User",
        };
        user1.PasswordHash = passwordHasher.HashPassword(user1, "Petar123$");

        var user2 = new User
        {
            Id = "f8d480c5-ebe1-45e3-a804-a9badf390003",
            UserName = "user2",
            NormalizedUserName = "USER2",
            Email = "user2@gmail.com",
            NormalizedEmail = "USER2@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            FirstName = "User2",
            LastName = "User2",
        };
        user2.PasswordHash = passwordHasher.HashPassword(user2, "Petar123$");

        var user3 = new User
        {
            Id = "c33ee900-c261-4195-b8d6-2ac802657d95",
            UserName = "user3",
            NormalizedUserName = "USER3",
            Email = "user3@gmail.com",
            NormalizedEmail = "USER3@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            FirstName = "User3",
            LastName = "User3",
        };
        user3.PasswordHash = passwordHasher.HashPassword(user3, "Petar123$");

        var user4 = new User
        {
            Id = "318f8ee8-cb12-4d95-9123-1d911a167f3f",
            UserName = "user4",
            NormalizedUserName = "USER4",
            Email = "user4@gmail.com",
            NormalizedEmail = "USER4@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            FirstName = "User4",
            LastName = "User4",
        };
        
        user4.PasswordHash = passwordHasher.HashPassword(user4, "Petar123$");
        
        builder.Entity<User>().HasData(admin1, manager1, manager2, user1, user2, user3, user4);
        
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
            RoleId = admin.Id, 
            UserId = admin1.Id, 
        });
        
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
            RoleId = manager.Id, 
            UserId = manager1.Id, 
        });
        
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
            RoleId = manager.Id, 
            UserId = manager2.Id, 
        });
        
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
            RoleId = user.Id, 
            UserId = user1.Id, 
        });
        
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
            RoleId = user.Id, 
            UserId = user2.Id, 
        });
        
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
            RoleId = user.Id, 
            UserId = user3.Id, 
        });
        
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
            RoleId = user.Id, 
            UserId = user4.Id, 
        });
    }
}