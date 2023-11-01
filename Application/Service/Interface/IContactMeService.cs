using Application.DTOs.SiteSide.ContactMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.ContactMe;

namespace Application.Service.Interface
{
    public interface IContactMeService
    {
        Task AddNewContactMeMessage(ContactMeDTO contactMeDTO);
        List<ContactMe> GetListOFContactMe();
        Task<ContactMe> FindContactMeByIdAsync(int ContactMeId);
        Task ChangeStatusOfSeenByAdmin(ContactMe contact);
    }
}
