using Application.DTOs.AdminSide.Experience;
using Domain.Models.Entities.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Interface
{
    public interface IExperienceService
    {
        public List<Experience> GetListOfExperience();

        //Get List Of An Experience For Show in Admin Panel 
        List<ListOFAnExperienceAdminSideDTO> GetListOfAnExperienceForShowinAdminPanel();

        Task AddExperienceToDataBase(CreateAnExperienceAdminSideDTO model);

        Task<Experience> GetAnExperienceByIdAsync(int ExperienceId);

        Task EditAnExperience(Experience Experience);

        Task DeleteAnExperience(Experience Experience);
    }

}
