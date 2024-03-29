﻿namespace DobroKuche.WebApp.Controllers
{
	using DobroKuche.Infrastructure.Data.Models;
	using DobroKuche.WebApp.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;

	public class UserController : BaseController
	{
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;

		public UserController(
			UserManager<AppUser> _userManager,
			SignInManager<AppUser> _signInManager)
		{
			userManager = _userManager;
			signInManager = _signInManager;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Register()
		{
			if (User?.Identity?.IsAuthenticated ?? false)
			{
				return RedirectToAction("Index", "Home");
			}

			var model = new RegisterViewModel();

			return View(model);
		}

		[HttpPost]
		[AllowAnonymous]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var user = new AppUser()
			{
				UserName = model.UserName,
				Email = model.Email,
				FirstName = model.FirstName,
				LastName = model.LastName
			};

			var result = await userManager.CreateAsync(user, model.Password);

			if (user.FirstName != null)
			{
				await userManager.AddClaimAsync(user, new System.Security.Claims.Claim("first_name", user.FirstName));
			}

			if (user.LastName != null)
			{
				await userManager.AddClaimAsync(user, new System.Security.Claims.Claim("last_name", user.LastName));
			}

			if (result.Succeeded)
			{
				return RedirectToAction("Login", "User");
			}

			foreach (var item in result.Errors)
			{
				ModelState.AddModelError("", item.Description);
			}

			return View(model);
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login()
		{
			if (User?.Identity?.IsAuthenticated ?? false)
			{
				return RedirectToAction("Index", "Home");
			}

			var model = new LoginViewModel();

			return View(model);
		}

		[HttpPost]
		[AllowAnonymous]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var user = await userManager.FindByEmailAsync(model.Email);

			if (user != null)
			{
				var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
			}

			ModelState.AddModelError("", "Invalid login");

			return View(model);
		}

		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();

			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult ForgotPassword()
		{
			if (User?.Identity?.IsAuthenticated ?? false)
			{
				return RedirectToAction("Index", "Home");
			}

			var model = new ForgotPasswordViewModel();

			return View(model);
		}

		[HttpPost]
		[AllowAnonymous]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var user = await userManager.FindByEmailAsync(model.Email);

			if (user != null)
			{
				var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
			}

			ModelState.AddModelError("", "Invalid login");

			return View(model);
		}
	}
}
