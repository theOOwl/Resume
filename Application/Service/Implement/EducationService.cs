using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.AdminSide.Education;
using Application.Service.Interface;
using Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;

namespace Application.Service.Implement
{
    public class EducationService : IEducationService
    {
        private readonly IEducationRepository _educationRepository;
        public EducationService(IEducationRepository educationRepository)
        {
               _educationRepository = educationRepository;
        }

        public async Task AddEducationToDataBase(CreateAnEducationAdminSideDTO model)
        {
            #region Object Mapping

            Education education = new Education();

            education.EducationTitle = model.EducationTitle;
            education.EducationDuration = model.EducationDuration;
            education.Description = model.Description;

            #endregion

            #region Add Education To Data Base

            await _educationRepository.AddEducationToDataBase(education);

            #endregion
        }

        public async Task EditAnEducation(Education education)
        {
            await _educationRepository.EditAnEducation(education);
        }

        public async Task DeleteAnEducation(Education education)
        {
            await _educationRepository.DeleteAnEducation(education);
        }

        public async Task<Education> GetAnEducationByIdAsync(int educationId)
        {
            return await _educationRepository.GetAnEducationByIdAsync(educationId);
        }

        public List<ListOFAnEducationAdminSideDTO> GetListOfAnEducationForShowinAdminPanel()
        {
            #region Get List Of An Educations From Data Base 

            List<Education> educations = _educationRepository.GetListOFEducations();

            #endregion

            #region Object Mapping

            List<ListOFAnEducationAdminSideDTO> returnModel = new List<ListOFAnEducationAdminSideDTO>();

            foreach (var edu in educations)
            {
                ListOFAnEducationAdminSideDTO childModel = new ListOFAnEducationAdminSideDTO();

                childModel.EducationTitle = edu.EducationTitle;
                childModel.EducationDuration = edu.EducationDuration;
                childModel.Id = edu.Id;

                returnModel.Add(childModel);
            }
            #endregion

            return returnModel;
        }
        public List<Education> GetListOFEducations()
        {
            return _educationRepository.GetListOFEducations();
        }
    }
}
