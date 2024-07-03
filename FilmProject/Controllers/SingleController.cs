using Microsoft.AspNetCore.Mvc;

namespace FilmProject.Controllers
{
	public class SingleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
