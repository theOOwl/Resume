using Application.DTOs.AdminSide.Education;
using Application.Service.Interface;
using Domain.Models.Entities.Education;
using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class EducationController : Controller
    {
        #region ctor
        private readonly IEducationService _educationService;
        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;   
        }
        #endregion
        #region List Of Educations

        [HttpGet]
        public IActionResult ListOfAnEducations()
        {
            var model = _educationService.GetListOFEducations();

            return View(model);
        }

        #endregion
        #region Create An Education

        [HttpGet]
        public IActionResult CreateAnEducation()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnEducation(CreateAnEducationAdminSideDTO model)
        {
            if (ModelState.IsValid)
            {
                await _educationService.AddEducationToDataBase(model);

                return RedirectToAction(nameof(ListOfAnEducations));
            }

            return View();
        }

        #endregion
        #region Edit An Education

        [HttpGet]
        public async Task<IActionResult> EditAnEducation(int educationId)
        {
            #region Get An Education By Id

            var education = await _educationService.GetAnEducationByIdAsync(educationId);

            #endregion

            return View(education);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnEducation(Education education)
        {
            #region Update An Education

            await _educationService.EditAnEducation(education);

            return RedirectToAction(nameof(ListOfAnEducations));

            #endregion

            return View(education);
        }

        #endregion
        #region Delete An Education

        [HttpGet]
        public async Task<IActionResult> DeleteAnEducation(int educationId)
        {
            #region Get An Education By Id

            var education = await _educationService.GetAnEducationByIdAsync(educationId);

            #endregion

            return View(education);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnEducation(Education education)
        {
            #region Update An Education

            await _educationService.DeleteAnEducation(education);

            return RedirectToAction(nameof(ListOfAnEducations));

            #endregion

            return View(education);
        }
        #endregion
    }
}
