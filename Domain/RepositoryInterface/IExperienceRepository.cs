using Domain.Models.Entities.Experience;

namespace Resume.Domain.RepositoryInterface
{
    public interface IExperienceRepository
    {
        //GetListOfExperience
        List<Experience> GetListOfExperience();
        Task AddExperienceToDataBase(Experience Experience);

        Task<Experience> GetAnExperienceByIdAsync(int ExperienceId);

        Task EditAnExperience(Experience Experience);

        Task DeleteAnExperience(Experience Experience);
    }
}
