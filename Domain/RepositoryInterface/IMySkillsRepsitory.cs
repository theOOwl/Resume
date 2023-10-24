using Domain.Models.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface
{
    public interface IMySkillsRepsitory
    {
        //GetListOfMySkills
        List<MySkills> GetListOfMySkills();
        Task AddMySkillsToDataBase(MySkills MySkills);

        Task<MySkills> GetAnMySkillsByIdAsync(int MySkillsId);

        Task EditAnMySkills(MySkills MySkills);

        Task DeleteAnMySkills(MySkills MySkills);
    }
}
