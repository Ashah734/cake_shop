using Cake_Shope.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cake_Shope.Controllers
{
    public class LoginController : Controller

    {
        UserDetails objlogauth = new UserDetails();
		private readonly SignInManager<UserDetails> _signInManager;

		public IActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> Index(UserDetails model)
		{
			bool isValue = objlogauth.checkuser(model);

			if (!isValue)
			{
                // HttpContext.Session.SetString("Name", model.fname.ToString());
                TempData["ErrorMessage"] = "Invalid username or password.";
                return RedirectToAction("Index", "Login");
			}
			else
			{
				HttpContext.Session.SetString("ID", model.Id.ToString());

				return RedirectToAction("Index", "Home");
			}

			// If ModelState is not valid, return to the login page with validation errors
		}

	}
}
