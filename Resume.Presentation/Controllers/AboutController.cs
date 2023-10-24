using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
