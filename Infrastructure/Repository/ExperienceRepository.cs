using Domain.Models.Entities.Experience;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
    public class ExperienceRepository : IExperienceRepository
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public ExperienceRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<Experience> GetListOfExperience()
        {
            return _context.Experiences.ToList();
        }
    }
}
