using Application.DTOs.SiteSide.ContactMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Interface
{
    public interface IContactMeService
    {
        Task AddNewContactMeMessage(ContactMeDTO contactMeDTO);
    }
}
