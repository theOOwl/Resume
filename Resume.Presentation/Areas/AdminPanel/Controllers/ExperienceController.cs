using Application.DTOs.AdminSide.Experience;
using Application.Service.Interface;
using Domain.Models.Entities.Experience;
using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ExperienceController : Controller
    {
        #region ctor
        private readonly IExperienceService _experienceService;
        public ExperienceController(IExperienceService ExperienceService)
        {
            _experienceService = ExperienceService;
        }
        #endregion
        #region List Of Experiences

        [HttpGet]
        public IActionResult ListOfAnExperience()
        {
            var model = _experienceService.GetListOfExperience();

            return View(model);
        }

        #endregion
        #region Create An Experience

        [HttpGet]
        public IActionResult CreateAnExperience()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnExperience(CreateAnExperienceAdminSideDTO model)
        {
            if (ModelState.IsValid)
            {
                await _experienceService.AddExperienceToDataBase(model);

                return RedirectToAction(nameof(ListOfAnExperience));
            }

            return View();
        }

        #endregion
        #region Edit An Experience

        [HttpGet]
        public async Task<IActionResult> EditAnExperience(int experienceId)
        {
            #region Get An Experience By Id

            var experience = await _experienceService.GetAnExperienceByIdAsync(experienceId);

            #endregion

            return View(experience);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnExperience(Experience experience)
        {
            #region Update An Experience

            await _experienceService.EditAnExperience(experience);

            return RedirectToAction(nameof(ListOfAnExperience));

            #endregion

            return View(experience);
        }

        #endregion
        #region Delete An Experience

        [HttpGet]
        public async Task<IActionResult> DeleteAnExperience(int experienceId)
        {
            #region Get An Experience By Id

            var experience = await _experienceService.GetAnExperienceByIdAsync(experienceId);

            #endregion

            return View(experience);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnExperience(Experience experience)
        {
            #region Update An Experience

            await _experienceService.DeleteAnExperience(experience);

            return RedirectToAction(nameof(ListOfAnExperience));

            #endregion

            return View(experience);
        }
        #endregion
    }
}
