namespace DobroKuche.Core.Contracts
{
	using DobroKuche.Core.Models;

	public interface ICourceService
	{
		Task<IEnumerable<CourseModel>> GetAllCoursesAsync();

		Task AddCourseAsync(AddCourseModel model);

		//Task DeleteCourseAsync();
	}
}
