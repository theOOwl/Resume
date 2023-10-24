using Domain.Models.Entities.Education;

namespace Resume.Domain.RepositoryInterface
{
    public interface IEducationRepository
    {
       
        List<Education> GetListOFEducations();
        Task AddEducationToDataBase(Education education);

        Task<Education> GetAnEducationByIdAsync(int educationId);

        Task EditAnEducation(Education education);

        Task DeleteAnEducation(Education education);
    }
}
