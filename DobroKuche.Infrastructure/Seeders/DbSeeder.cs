﻿namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Logging;
	using System;
	using System.Threading.Tasks;

	public class DbSeeder : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			if (dbContext == null)
			{
				throw new ArgumentNullException(nameof(dbContext));
			}

			if (serviceProvider == null)
			{
				throw new ArgumentNullException(nameof(serviceProvider));
			}

			var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(DbSeeder));

			var seeders = new List<ISeeder>
			{
				new RolesSeeder(),
				new UsersSeeder(),
				new TypesOfExerciseSeered(),
				new CoursesSeeder(),
				new TagsSeeder(),
				new ArticlesSeeder()
			};

			foreach (var seeder in seeders)
			{
				await seeder.SeedAsync(dbContext, serviceProvider);
				await dbContext.SaveChangesAsync();
				logger.LogInformation($"Seeder {seeder.GetType().Name} completed.");
			}
		}
	}
}
