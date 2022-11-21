namespace DobroKuche.WebApp.Controllers
{
	using DobroKuche.Core.Contracts;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	public class CourceController : BaseController
	{
		private readonly ICourceService courceService;

		public CourceController(ICourceService _courceService)
		{
			courceService= _courceService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> AllCourses()
		{
			return View();
		}
	}
}
