namespace DobroKuche.Core.Contracts
{
	using DobroKuche.Core.Models;

	public interface ICourseService
	{
		Task<IEnumerable<CourseModel>> GetAllCoursesAsync();

		Task AddCourseAsync(AddCourseModel model);

		//Task DeleteCourseAsync();
	}
}
