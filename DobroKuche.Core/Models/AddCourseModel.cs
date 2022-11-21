namespace DobroKuche.Core.Models
{
	using DobroKuche.Infrastructure.Data.Common;
	using DobroKuche.Infrastructure.Data.Models.Enums;
	using DobroKuche.Infrastructure.Data.Models;
	using System.ComponentModel.DataAnnotations;

	public class AddCourseModel
	{
		public AddCourseModel()
		{
			Participants = new List<AppUser>();
			Types = new List<TypeOfExercise>();
			CreatedOn = DateTime.Now;
			LastUpdatedOn = CreatedOn;
			IsDeleted = false;
		}

		[Required(AllowEmptyStrings = false)]
		[StringLength(DataConstants.CourseTitleMaxLenght, MinimumLength = DataConstants.CourseTitleMinLenght)]
		public string Title { get; set; } = null!;

		[Required(AllowEmptyStrings = false)]
		[StringLength(DataConstants.CourseDescriptionMaxLenght, MinimumLength = DataConstants.CourseDescriptionMinLenght)]
		public string Description { get; set; } = null!;

		[Required]
		public AgeGroup AgeGroup { get; set; }

		[Required]
		public Category Category { get; set; }

		public List<TypeOfExercise> Types { get; set; }

		public List<AppUser> Participants { get; set; }

		public DateTime CreatedOn { get; set; }

		public DateTime LastUpdatedOn { get; set; }

		public bool IsDeleted { get; set; }
	}
}
