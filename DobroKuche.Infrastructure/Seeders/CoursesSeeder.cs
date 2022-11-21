namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;
	using DobroKuche.Infrastructure.Data.Models;
	using System;
	using System.Threading.Tasks;

	internal class CoursesSeeder : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			if (dbContext.Courses.Any())
			{
				return;
			}

			var types = dbContext.TypesOfExercise;

			var courses = new List<Course>()
			{
				new Course()
				{
					Title = "Бебешки истории",
					AgeGroup = Data.Models.Enums.AgeGroup.Baby,
					Category = Data.Models.Enums.Category.Еlemental,
					Description = "С помощта на този курс ще съумеете да се опознаете с новия член на Вашето семейство.",
					Types = new List<TypeOfExercise>()
					{
						types.FirstOrDefault(t => t.Name == "Individual"),
						types.FirstOrDefault(t => t.Name == "Group"),
						types.FirstOrDefault(t => t.Name == "Online")
					}
				},

				new Course()
				{
					Title = "Общо послушание",
					AgeGroup = Data.Models.Enums.AgeGroup.Teenage,
					Category = Data.Models.Enums.Category.Average,
					Description = "Ако Вашият любимец е палав и изпитвате затруднения с контрола над поведението му, това е решението за Вас.",
					Types = new List<TypeOfExercise>()
					{
						types.FirstOrDefault(t => t.Name == "Individual"),
						types.FirstOrDefault(t => t.Name == "Group"),
						types.FirstOrDefault(t => t.Name == "Online"),
						types.FirstOrDefault(t => t.Name == "Group")
					}
				},

				new Course()
				{
					Title = "Контрол над агресията",
					AgeGroup = Data.Models.Enums.AgeGroup.Any,
					Category = Data.Models.Enums.Category.Advanced,
					Description = "По време на този курс ще се опитаме да помогнем както на кучето да разтовари напрежението, така и на Вас да овладеете емоциите му.",
					Types = new List<TypeOfExercise>()
					{
						types.FirstOrDefault(t => t.Name == "Individual")
					}
				}
			};

			await dbContext.Courses.AddRangeAsync(courses);
			await dbContext.SaveChangesAsync();
		}
	}
}