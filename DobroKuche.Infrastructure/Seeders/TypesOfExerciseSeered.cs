namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;
	using DobroKuche.Infrastructure.Data.Models;
	using System;
	using System.Threading.Tasks;

	internal class TypesOfExerciseSeered : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			if (dbContext.TypesOfExercise.Any())
			{
				return;
			}

			var types = new List<TypeOfExercise>
			{
				new TypeOfExercise
				{
					Name = "Individual"
				},

				new TypeOfExercise
				{
					Name = "Group"
				},

				new TypeOfExercise
				{
					Name = "Couples"
				},

				new TypeOfExercise
				{
					Name = "Online"
				}
			};

			await dbContext.TypesOfExercise.AddRangeAsync(types);
			await dbContext.SaveChangesAsync();
		}
	}
}
