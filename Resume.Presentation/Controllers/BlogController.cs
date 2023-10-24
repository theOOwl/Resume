using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
