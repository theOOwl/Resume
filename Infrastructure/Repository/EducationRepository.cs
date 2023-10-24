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

        public async Task AddEducationToDataBase(Education education)
        {
            await _context.Educations.AddAsync(education);
            await _context.SaveChangesAsync();
        }

        public Task<Education> GetAnEducationByIdAsync(int educationId)
        {
            return _context.Educations.FirstOrDefaultAsync(p => p.Id == educationId);
        }

        public async Task EditAnEducation(Education education)
        {
            _context.Educations.Update(education);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnEducation(Education education)
        {
            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
        }
    }
}
