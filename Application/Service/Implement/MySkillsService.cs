using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.AdminSide.MySkills;
using Application.Service.Interface;
using Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Application.Service.Implement
{
    public class MySkillsService : IMySkillsService
    {
        private readonly IMySkillsRepsitory _MySkillsRepository;
        public MySkillsService(IMySkillsRepsitory MySkillsRepository)
        {
            _MySkillsRepository = MySkillsRepository;
        }

        public async Task AddMySkillsToDataBase(CreateAnMySkillsAdminSideDTO model)
        {
            #region Object Mapping

            MySkills MySkills = new MySkills();

            MySkills.SkillTille = model.SkillTille;
            MySkills.Percentage = model.Percentage;


            #endregion

            #region Add MySkills To Data Base

            await _MySkillsRepository.AddMySkillsToDataBase(MySkills);

            #endregion
        }

        public async Task EditAnMySkills(MySkills MySkills)
        {
            await _MySkillsRepository.EditAnMySkills(MySkills);
        }

        public async Task DeleteAnMySkills(MySkills MySkills)
        {
            await _MySkillsRepository.DeleteAnMySkills(MySkills);
        }

        public async Task<MySkills> GetAnMySkillsByIdAsync(int MySkillsId)
        {
            return await _MySkillsRepository.GetAnMySkillsByIdAsync(MySkillsId);
        }

        public List<ListOFAnMySkillsAdminSideDTO> GetListOfAnMySkillsForShowinAdminPanel()
        {
            #region Get List Of An MySkillss From Data Base 

            List<MySkills> MySkillss = _MySkillsRepository.GetListOfMySkills();

            #endregion

            #region Object Mapping

            List<ListOFAnMySkillsAdminSideDTO> returnModel = new List<ListOFAnMySkillsAdminSideDTO>();

            foreach (var edu in MySkillss)
            {
                ListOFAnMySkillsAdminSideDTO childModel = new ListOFAnMySkillsAdminSideDTO();

                childModel.SkillTille= edu.SkillTille;
                childModel.Percentage = edu.Percentage;
                childModel.Id = edu.Id;

                returnModel.Add(childModel);
            }
            #endregion

            return returnModel;
        }

        public List<MySkills> GetListOfMySkills()
        {
            return _MySkillsRepository.GetListOfMySkills();
        }
    }
}
