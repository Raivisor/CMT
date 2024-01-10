using Microsoft.AspNetCore.Mvc;

namespace СМТ.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
