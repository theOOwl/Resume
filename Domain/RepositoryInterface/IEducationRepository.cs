using Domain.Models.Entities.Education;

namespace Resume.Domain.RepositoryInterface
{
    public interface IEducationRepository
    {
        //GetListOFEducations
        List<Education> GetListOFEducations();
    }
}
