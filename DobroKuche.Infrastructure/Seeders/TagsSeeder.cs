namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;
	using DobroKuche.Infrastructure.Data.Models;
	using System;
	using System.Threading.Tasks;

	internal class TagsSeeder : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			if (dbContext.Tags.Any())
			{
				return;
			}

			var tags = new List<Tag>()
			{
				new Tag
				{
					Name = "#Комуникация",
				},

				new Tag
				{
					Name = "#Агресия",
				},

				new Tag
				{
					Name = "#Хранене",
				},

				new Tag
				{
					Name = "#Спорт",
				},

				new Tag
				{
					Name = "#Разходки",
				},

				new Tag
				{
					Name = "#Бебе",
				},

				new Tag
				{
					Name = "#Игри",
				}
			};

			await dbContext.Tags.AddRangeAsync(tags);
			await dbContext.SaveChangesAsync();
		}
	}
}