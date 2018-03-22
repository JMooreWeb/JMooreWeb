using JMooreWeb.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;

namespace JMooreWeb.Data
{
	public static class Seeder
    {
		//public UserManager<User> UserManager { get; private set; }

		public static void Seed(DatabaseContext context)
		{
			context.Database.EnsureCreated();

			if (context.Users.Any())
			{
				return; // DB has been seeded
			}

			#region Roles
			var roles = new Role[]
				{
				new Role
				{
					Name = "admin",
					NormalizedName = "ADMIN",
					ConcurrencyStamp = Guid.NewGuid().ToString()
				}
				};
			foreach (var role in roles)
			{
				context.Roles.Add(role);
			}
			#endregion

			#region Users
			//var userManager = new UserManager(;
			//var passwordHash = userManager.PasswordHasher.HashPassword("Admin@123");

			var users = new User[]
				{
				new User
				{
					AccessFailedCount = 0,
					ConcurrencyStamp = Guid.NewGuid().ToString(),
					EmailConfirmed = true,
					FirstName = "Administrator",
					LastName = null,
					LockoutEnabled = false,
					LockoutEnd = null,
					UserName = "admin",
					Email = "admin@bcpao.us",
					NormalizedEmail = "ADMIN@BCPAO.US",
					NormalizedUserName = "ADMIN",
					PasswordHash = null,
					PhoneNumber = null,
					PhoneNumberConfirmed = false,
					SecurityStamp = Guid.NewGuid().ToString(),
					TwoFactorEnabled = false,
					CreateDate = DateTime.Now
				}
			};
			foreach (var user in users)
			{
				context.Users.Add(user);
			} 
			#endregion

			context.SaveChanges();
		}
    }
}
