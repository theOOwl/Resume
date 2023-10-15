using Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
    public class MySkillsRepository : IMySkillsRepsitory
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public MySkillsRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<MySkills> GetListOfMySkills()
        {
            return _context.MySkills.ToList();  
        }
    }
}
