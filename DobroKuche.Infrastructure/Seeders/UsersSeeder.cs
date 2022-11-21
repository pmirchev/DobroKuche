namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;
	using DobroKuche.Infrastructure.Data.Common;
	using DobroKuche.Infrastructure.Data.Models;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.Extensions.DependencyInjection;
	using System;
	using System.Threading.Tasks;

	internal class UsersSeeder : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			if (dbContext.Users.Any())
			{
				return;
			}

			var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

			await CreateUserAsync(
				userManager,
				DataConstants.OwnerUserame,
				DataConstants.OwnerEmail,
				new List<string>()
				{
					DataConstants.OwnerRoleName,
					DataConstants.AdminRoleName
				});

			await CreateUserAsync(
				userManager,
				DataConstants.FirstAdminUserame,
				DataConstants.FirstAdminEmail,
				new List<string>()
				{
					DataConstants.AdminRoleName
				});

			await CreateUserAsync(
				userManager,
				DataConstants.SecondAdminUserame,
				DataConstants.SecondAdminEmail,
				new List<string>()
				{
					DataConstants.AdminRoleName
				});

			await CreateUserAsync(
				userManager,
				DataConstants.GuestUserame,
				DataConstants.GuestEmail,
				new List<string>()
				{
					DataConstants.UserRoleName
				});
		}

		private async Task CreateUserAsync(
			UserManager<AppUser> userManager,
			string userame,
			string email,
			List<string> roleNames)
		{
			var user = new AppUser()
			{
				UserName = userame,
				Email = email,
			};

			await userManager.CreateAsync(user, $"{userame}1234");

			foreach (var roleName in roleNames)
			{
				var result = await userManager.AddToRoleAsync(user, roleName);

				if (!result.Succeeded)
				{
					throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
				}
			}
		}
	}
}
