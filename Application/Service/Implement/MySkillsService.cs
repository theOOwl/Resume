using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Service.Interface;
using Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Application.Service.Implement
{
    public class MySkillsService : IMySkillsService
    {
        private readonly IMySkillsRepsitory _mySkillsRepsitory;
        public MySkillsService(IMySkillsRepsitory mySkillsRepsitory)
        {
            _mySkillsRepsitory = mySkillsRepsitory;
        }
        public List<MySkills> GetListOfMySkills()
        {
            return _mySkillsRepsitory.GetListOfMySkills();
        }
    }
}
