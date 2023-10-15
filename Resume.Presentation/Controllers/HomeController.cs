using Domain.Models.Entities.Education;
using Domain.Models.Entities.Experience;
using Domain.Models.Entities.MySkills;
using Microsoft.AspNetCore.Mvc;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;
using Resume.Presentation.Models;
using System.Diagnostics;
using Application.DTOs.SiteSide.Home_Index;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        #region Ctor

        private readonly IEducationRepository _educationRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly IMySkillsRepsitory _mySkillsRepsitory;

        public HomeController(IEducationRepository educationRepository,
                              IExperienceRepository experienceRepository,
                              IMySkillsRepsitory mySkillsRepsitory)
        {
            _educationRepository = educationRepository;
            _experienceRepository = experienceRepository;
            _mySkillsRepsitory = mySkillsRepsitory;
        }

        #endregion
        public IActionResult Index()
        {
            #region My Skills 

            List<MySkills> mySkills = _mySkillsRepsitory.GetListOfMySkills();

            #endregion

            #region Educations

            List<Education> educations = _educationRepository.GetListOFEducations();

            #endregion

            #region Experience

            List<Experience> experiences = _experienceRepository.GetListOfExperience();

            #endregion

            #region Fill Instance Model 

            HomeIndexModelDTO model = new HomeIndexModelDTO();

            model.Experience = experiences;
            model.Educations = educations;
            model.MySkills = mySkills;

            #endregion

            #region ViewBag() , ViewData[] , TempData[]

            //ViewBag() , ViewData[] , TempData[]

            //ViewBag.Experience = experiencesAsync;

            //ViewBag.MySkills = mySkillsAsync;

            //ViewBag.Educations = educationsAsync;

            #endregion

            return View(model);
        }
    

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Daneshkar()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}