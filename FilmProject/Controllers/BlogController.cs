using Microsoft.AspNetCore.Mvc;

namespace FilmProject.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
