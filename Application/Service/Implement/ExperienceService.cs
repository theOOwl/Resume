using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Service.Interface;
using Domain.Models.Entities.Experience;
using Resume.Domain.RepositoryInterface;

namespace Application.Service.Implement
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
        public ExperienceService(IExperienceRepository experienceRepository)
        {
                _experienceRepository = experienceRepository;   
        }
        public List<Experience> GetListOfExperience()
        {
            return _experienceRepository.GetListOfExperience();
        }
    }
}
