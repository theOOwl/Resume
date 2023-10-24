using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.SiteSide.Home_Index;
using Application.Service.Interface;
using Domain.Models.Entities.Education;
using Domain.Models.Entities.Experience;
using Domain.Models.Entities.MySkills;
using Application.Service.Implement;

namespace Application.Service.Implement
{
    public class DashboardService : IDashboardService
    {
        #region Ctor

        private readonly IEducationService _educationService;
        private readonly IExperienceService _experienceService;
        private readonly IMySkillsService _mySkillsService;

        public DashboardService(IEducationService educationService,
                              IExperienceService experienceService,
                              IMySkillsService mySkillsService)
        {
            _educationService = educationService;
            _experienceService = experienceService;
            _mySkillsService = mySkillsService;
        }

        #endregion

        public async Task<HomeIndexModelDTO> FillDashboardModel()
        {
            #region My Skills 

            List<MySkills> mySkills = _mySkillsService.GetListOfMySkills();

            #endregion

            #region Educations

            List<Education> educations = _educationService.GetListOFEducations();

            #endregion

            #region Experience

            List<Experience> experiences = _experienceService.GetListOfExperience();

            #endregion

            #region Fill Instance Model 

            HomeIndexModelDTO model = new HomeIndexModelDTO();

            model.Experience = experiences;
            model.Educations = educations;
            model.MySkills = mySkills;

            #endregion

            return model;
        }
    }
}
