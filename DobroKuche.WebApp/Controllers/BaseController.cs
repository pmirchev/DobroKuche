namespace DobroKuche.WebApp.Controllers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Mvc.Filters;

	[Authorize]
	public class BaseController : Controller
	{
		public string UserFullName
		{
			get
			{
				string fullName = string.Empty;

				if (User != null)
				{
					fullName = $"{User.Claims.FirstOrDefault(c => c.Type == "first_name")?.Value} {User.Claims.FirstOrDefault(c => c.Type == "last_name")?.Value}";
				}

				return fullName;
			}
		}

		public override void OnActionExecuted(ActionExecutedContext context)
		{
			ViewBag.UserFullName = UserFullName;

			base.OnActionExecuted(context);
		}
	}
}
