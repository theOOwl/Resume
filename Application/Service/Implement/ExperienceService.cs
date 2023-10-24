using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.AdminSide.Experience;
using Application.Service.Interface;
using Domain.Models.Entities.Experience;
using Resume.Domain.RepositoryInterface;

namespace Application.Service.Implement
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _ExperienceRepository;
        public ExperienceService(IExperienceRepository ExperienceRepository)
        {
            _ExperienceRepository = ExperienceRepository;
        }

        public async Task AddExperienceToDataBase(CreateAnExperienceAdminSideDTO model)
        {
            #region Object Mapping

            Experience Experience = new Experience();

            Experience.ExperienceTitle = model.ExperienceTitle;
            Experience.ExperienceDuration = model.ExperienceDuration;
            Experience.CompanySite = model.CompanySite;
            Experience.CompanyName = model.CompanyName;
            Experience.Description = model.Description;

            #endregion

            #region Add Experience To Data Base

            await _ExperienceRepository.AddExperienceToDataBase(Experience);

            #endregion
        }

        public async Task EditAnExperience(Experience Experience)
        {
            await _ExperienceRepository.EditAnExperience(Experience);
        }

        public async Task DeleteAnExperience(Experience Experience)
        {
            await _ExperienceRepository.DeleteAnExperience(Experience);
        }

        public async Task<Experience> GetAnExperienceByIdAsync(int ExperienceId)
        {
            return await _ExperienceRepository.GetAnExperienceByIdAsync(ExperienceId);
        }

        public List<ListOFAnExperienceAdminSideDTO> GetListOfAnExperienceForShowinAdminPanel()
        {
            #region Get List Of An Experiences From Data Base 

            List<Experience> Experiences = _ExperienceRepository.GetListOfExperience();

            #endregion

            #region Object Mapping

            List<ListOFAnExperienceAdminSideDTO> returnModel = new List<ListOFAnExperienceAdminSideDTO>();

            foreach (var edu in Experiences)
            {
                ListOFAnExperienceAdminSideDTO childModel = new ListOFAnExperienceAdminSideDTO();

                childModel.ExperienceTitle = edu.ExperienceTitle;
                childModel.ExperienceDuration = edu.ExperienceDuration;
                childModel.CompanySite = edu.CompanySite;
                childModel.CompanyName = edu.CompanyName;
                childModel.Id = edu.Id;

                returnModel.Add(childModel);
            }
            #endregion

            return returnModel;
        }

        public List<Experience> GetListOfExperience()
        {
            return _ExperienceRepository.GetListOfExperience();
        }
    }
}
