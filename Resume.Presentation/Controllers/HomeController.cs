using Domain.Models.Entities.Education;
using Domain.Models.Entities.Experience;
using Domain.Models.Entities.MySkills;
using Microsoft.AspNetCore.Mvc;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;
using System.Diagnostics;
using Application.DTOs.SiteSide.Home_Index;
using Application.Service.Implement;
using Application.Service.Interface;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        #region Ctor

        private readonly IDashboardService _dashboardService;


        public HomeController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        #endregion
        #region Index
        public async Task<IActionResult> Index()
        {
            var model = await _dashboardService.FillDashboardModel();

            return View(model);
        }
        #endregion
    }
}