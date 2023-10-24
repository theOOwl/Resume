using Domain.Models.Entities.MySkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Interface
{
    public interface IMySkillsService
    {
        public List<MySkills> GetListOfMySkills();
    }
}
