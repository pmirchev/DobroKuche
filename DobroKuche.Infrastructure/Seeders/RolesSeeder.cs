namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;
	using DobroKuche.Infrastructure.Data.Common;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.Extensions.DependencyInjection;
	using System;
	using System.Threading.Tasks;

	internal class RolesSeeder : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			await SeedRoleAsync(roleManager, DataConstants.OwnerRoleName);
			await SeedRoleAsync(roleManager, DataConstants.AdminRoleName);
			await SeedRoleAsync(roleManager, DataConstants.UserRoleName);
		}

		private async Task SeedRoleAsync(RoleManager<IdentityRole> roleManager, string roleName)
		{
			var role = await roleManager.FindByNameAsync(roleName);

			if (role == null)
			{
				var result = await roleManager.CreateAsync(new IdentityRole(roleName));

				if (!result.Succeeded)
				{
					throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
				}
			}
		}
	}
}
