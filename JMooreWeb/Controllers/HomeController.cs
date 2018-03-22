using JMooreWeb.Data;
using JMooreWeb.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JMooreWeb.Controllers
{
	[Authorize]
	public class HomeController : BaseController
	{
		public HomeController(UserManager<User> userManager) : base(userManager)
		{
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
