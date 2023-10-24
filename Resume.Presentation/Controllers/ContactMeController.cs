using Application.DTOs.SiteSide.ContactMe;
using Application.Service.Interface;
using Domain.Entities.ContactMe;
using Domain.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class ContactMeController : Controller
    {
        private readonly IContactMeService _contactMeService;   
        public ContactMeController(IContactMeService contactMeService)
        {
            _contactMeService = contactMeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken] 
        public async Task <IActionResult> Index(ContactMeDTO contactMeDTO)
        {
            if (ModelState.IsValid)
            {
                await _contactMeService.AddNewContactMeMessage(contactMeDTO);
                return RedirectToAction("Index", "ContactMe");
            }
            return View();
        }
    }
}
