using Application.DTOs.AdminSide.MySkills;
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
        //Get List Of An MySkills For Show in Admin Panel 
        List<ListOFAnMySkillsAdminSideDTO> GetListOfAnMySkillsForShowinAdminPanel();

        Task AddMySkillsToDataBase(CreateAnMySkillsAdminSideDTO model);

        Task<MySkills> GetAnMySkillsByIdAsync(int MySkillsId);

        Task EditAnMySkills(MySkills MySkills);

        Task DeleteAnMySkills(MySkills MySkills);
    }
}
