
using Domain;
using Persistence.Utility;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Users.Any()) return;

            var users = new List<User> 
            {
                new User
                {
                    Id = new Guid(),
                    Username = "admin",
                    Email = "admin@example.com",
                    PasswordHash = PasswordHashingUtility.HashPassword("admin"),
                    StartingWeight = 187.2f,
                    CurrentWeight = 183.5f,
                    TargetWeight = 135.0f,
                    JoinDate = DateTime.UtcNow.AddDays(-51)
                },
                new User
                {
                    Id = new Guid(),
                    Username = "jacquelynneh",
                    Email = "jacquelynneh@example.com",
                    PasswordHash = PasswordHashingUtility.HashPassword("Password123!!"),
                    StartingWeight = 213.2f,
                    CurrentWeight = 207.2f,
                    TargetWeight = 120.3f,
                    JoinDate = DateTime.UtcNow.AddDays(-14)
                },
                new User 
                {
                    Id = new Guid(),
                    Username = "pheiman",
                    Email = "pheiman@example.com",
                    PasswordHash = PasswordHashingUtility.HashPassword("Davin1123!!"),
                    StartingWeight = 325.3f,
                    CurrentWeight = 324.1f,
                    TargetWeight = 220.4f,
                    JoinDate = DateTime.UtcNow.AddDays(-2)
                }
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }        
    }
}