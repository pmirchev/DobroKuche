namespace DobroKuche.Core.Services
{
	using DobroKuche.Core.Contracts;
	using DobroKuche.Core.Models;
	using DobroKuche.Infrastructure.Data.Common;
	using DobroKuche.Infrastructure.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public class CourseService : ICourseService
	{
		private readonly IRepository repository;

		public CourseService(IRepository _repository)
		{
			repository = _repository;
		}

		public async Task AddCourseAsync(AddCourseModel model)
		{
			var course = new Course()
			{
				Title = model.Title,
				Description = model.Description,
				AgeGroup = model.AgeGroup,
				Category = model.Category,
				Types = model.Types
			};

			await repository.AddAsync(course);
			await repository.SaveChangesAsync();
		}

		public async Task<IEnumerable<CourseModel>> GetAllCoursesAsync()
		{
			List<CourseModel> result = await repository.AllReadonly<Course>()
				.Include(t => t.Types)
				.Select(c => new CourseModel()
				{
					Title = c.Title,
					Description = c.Description,
					AgeGroup = c.AgeGroup,
					Category = c.Category,
					Types = c.Types
							.Select(n => new TypesOfExerciseModel()
							{
								Name = n.Name
							})
							.ToList()
				})
				.ToListAsync();

			return result;
		}
	}
}
