using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class GitHubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
