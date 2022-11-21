namespace DobroKuche.Infrastructure.Data.Models
{
	using DobroKuche.Infrastructure.Data.Common;
	using System.ComponentModel.DataAnnotations;

	public class TypeOfExercise
	{
		public TypeOfExercise()
		{
			Courses = new List<Course>();
		}

		[Key]
		public int Id { get; set; }

		[Required(AllowEmptyStrings = false)]
		[MaxLength(DataConstants.TypeNameMaxLenght)]
		public string Name { get; set; } = null!;

		public List<Course> Courses { get; set; }
	}
}
