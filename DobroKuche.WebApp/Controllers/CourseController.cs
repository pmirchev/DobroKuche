namespace DobroKuche.WebApp.Controllers
{
	using DobroKuche.Core.Contracts;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	public class CourseController : BaseController
	{
		private readonly ICourseService courseService;

		public CourseController(ICourseService _courseService)
		{
			courseService = _courseService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> AllCourses()
		{
			//var model = await courseService.GetAllCoursesAsync();

			//return View(model);
			return View();
		}
	}
}
