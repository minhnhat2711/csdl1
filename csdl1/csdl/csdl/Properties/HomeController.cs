using Microsoft.AspNetCore.Mvc;

namespace csdl.Properties
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
