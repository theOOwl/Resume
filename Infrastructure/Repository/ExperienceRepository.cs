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

        public async Task AddExperienceToDataBase(Experience Experience)
        {
            await _context.Experiences.AddAsync(Experience);
            await _context.SaveChangesAsync();
        }

        public Task<Experience> GetAnExperienceByIdAsync(int ExperienceId)
        {
            return _context.Experiences.FirstOrDefaultAsync(p => p.Id == ExperienceId);
        }

        public async Task EditAnExperience(Experience Experience)
        {
            _context.Experiences.Update(Experience);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnExperience(Experience Experience)
        {
            _context.Experiences.Remove(Experience);
            await _context.SaveChangesAsync();
        }
    }
}
