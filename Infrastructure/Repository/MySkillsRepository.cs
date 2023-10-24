using Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;
using Resume.Domain.RepositoryInterface;
using Microsoft.EntityFrameworkCore;

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

            public async Task AddMySkillsToDataBase(MySkills MySkills)
            {
                await _context.MySkills.AddAsync(MySkills);
                await _context.SaveChangesAsync();
            }

            public Task<MySkills> GetAnMySkillsByIdAsync(int MySkillsId)
            {
                return _context.MySkills.FirstOrDefaultAsync(p => p.Id == MySkillsId);
            }

            public async Task EditAnMySkills(MySkills MySkills)
            {
                _context.MySkills.Update(MySkills);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAnMySkills(MySkills MySkills)
            {
                _context.MySkills.Remove(MySkills);
                await _context.SaveChangesAsync();
            }
        }
    }

