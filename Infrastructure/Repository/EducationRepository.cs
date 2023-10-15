using Domain.Models.Entities.Education;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
    public class EducationRepository : IEducationRepository
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public EducationRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<Education> GetListOFEducations()
        {
            return _context.Educations.ToList();
        }
    }
}
