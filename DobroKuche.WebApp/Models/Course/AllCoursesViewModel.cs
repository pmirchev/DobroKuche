namespace DobroKuche.WebApp.Models
{
	using DobroKuche.Core.Models;
	using DobroKuche.Infrastructure.Data.Models.Enums;

	public class CourseModelView
	{
		public CourseModelView()
		{
			Types = new List<TypesOfExerciseModel>();
		}

		public string Title { get; set; } = null!;

		public string Description { get; set; } = null!;

		public AgeGroup AgeGroup { get; set; }

		public Category Category { get; set; }

		public List<TypesOfExerciseModel> Types { get; set; }
	}
}
