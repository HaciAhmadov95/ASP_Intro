using Microsoft.AspNetCore.Mvc;

namespace Asp.intro.Controllers
{
    public class AboutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
