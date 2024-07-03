using Microsoft.AspNetCore.Mvc;

namespace FilmProject.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
