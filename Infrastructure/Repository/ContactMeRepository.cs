using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.ContactMe;
using Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;


namespace Infrastructure.Repository
{
    public class ContactMeRepository : IContactMeRepository
    {

        private readonly ResumeDbContext _context;

        public ContactMeRepository(ResumeDbContext Context)
        {
                _context = Context;
        }

        public async Task AddContactMeToDataBase(ContactMe contact)
        {
            await _context.ContactMe.AddAsync(contact);
            await _context.SaveChangesAsync();  
        }
        public async Task<ContactMe> FindContactMeByIdAsync(int ContactMeId)
        {
            return _context.ContactMe.FirstOrDefault(p => p.Id == ContactMeId && p.IsSeenByAdmin == true);
        }
        public async Task ChangeStatusOfSeenByAdmin(ContactMe contact)
        {
            _context.ContactMe.Update(contact);
            await _context.SaveChangesAsync();
        }

        public List<ContactMe> GetListOFContactMe()
        {
            return _context.ContactMe.ToList(); 
        }
    }
}
