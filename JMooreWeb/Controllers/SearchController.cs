using Microsoft.AspNetCore.Mvc;

namespace JMooreWeb.Controllers
{
   public class SearchController : BaseController
	{
		public SearchController() : base()
		{
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
