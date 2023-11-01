using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.ContactMe;


namespace Domain.RepositoryInterface
{
    public interface IContactMeRepository
    {
        Task AddContactMeToDataBase (ContactMe contact);
        List<ContactMe> GetListOFContactMe();
        Task ChangeStatusOfSeenByAdmin(ContactMe contact);
        Task<ContactMe> FindContactMeByIdAsync(int ContactMeId);
    } 
}
