using Microsoft.AspNetCore.Mvc;

namespace JMooreWeb.Controllers
{
   public class UsersController : BaseController
	{
		public UsersController() : base()
		{
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
