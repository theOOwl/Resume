using Application.DTOs.AdminSide.MySkills;
using Application.Service.Interface;
using Domain.Models.Entities.MySkills;
using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class MySkillsController : Controller
    {
        #region ctor
        private readonly IMySkillsService _MySkillsService;
        public MySkillsController(IMySkillsService MySkillsService)
        {
            _MySkillsService = MySkillsService;
        }
        #endregion
        #region List Of MySkillss

        [HttpGet]
        public IActionResult ListOfAnMySkills()
        {
            var model = _MySkillsService.GetListOfMySkills();

            return View(model);
        }

        #endregion
        #region Create An MySkills

        [HttpGet]
        public IActionResult CreateAnMySkills()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnMySkills(CreateAnMySkillsAdminSideDTO model)
        {
            if (ModelState.IsValid)
            {
                await _MySkillsService.AddMySkillsToDataBase(model);

                return RedirectToAction(nameof(ListOfAnMySkills));
            }

            return View();
        }

        #endregion
        #region Edit An MySkills

        [HttpGet]
        public async Task<IActionResult> EditAnMySkills(int MySkillsId)
        {
            #region Get An MySkills By Id

            var MySkills = await _MySkillsService.GetAnMySkillsByIdAsync(MySkillsId);

            #endregion

            return View(MySkills);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnMySkills(MySkills MySkills)
        {
            #region Update An MySkills

            await _MySkillsService.EditAnMySkills(MySkills);

            return RedirectToAction(nameof(ListOfAnMySkills));

            #endregion

            return View(MySkills);
        }

        #endregion
        #region Delete An MySkills

        [HttpGet]
        public async Task<IActionResult> DeleteAnMySkills(int MySkillsId)
        {
            #region Get An MySkills By Id

            var MySkills = await _MySkillsService.GetAnMySkillsByIdAsync(MySkillsId);

            #endregion

            return View(MySkills);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnMySkills(MySkills MySkills)
        {
            #region Update An MySkills

            await _MySkillsService.DeleteAnMySkills(MySkills);

            return RedirectToAction(nameof(ListOfAnMySkills));

            #endregion

            return View(MySkills);
        }
        #endregion
    }
}
