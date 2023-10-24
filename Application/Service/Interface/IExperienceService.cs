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
    }
}
