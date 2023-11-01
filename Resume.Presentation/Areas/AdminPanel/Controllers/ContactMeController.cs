using Application.Service.Interface;
using Domain.Entities.ContactMe;
using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ContactMeController : Controller
    {
       
        #region ctor
        private readonly IContactMeService _contactMeService;
        public ContactMeController(IContactMeService contactMeService)
        {
            _contactMeService = contactMeService;
        }
        #endregion
        #region List Of ContactMe

        [HttpGet]
        public IActionResult ListOfAnContactMe()
        {
            var model = _contactMeService.GetListOFContactMe();

            return View(model);
        }
        #endregion
        #region Edit An ContactMe

        [HttpGet]
        public async Task<IActionResult> ChangeStatusOfSeenByAdmin(int educationId)
        {

            #region  Find An ContactMe By Id

            var education = await _contactMeService.FindContactMeByIdAsync(educationId);

            #endregion

            return View(education);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeStatusOfSeenByAdmin(ContactMe contactMe)
        {
            #region Update An Education

            await _contactMeService.ChangeStatusOfSeenByAdmin(contactMe);

            return RedirectToAction(nameof(ListOfAnContactMe));

            #endregion

            return View(contactMe);
        }

        #endregion
    }
}
