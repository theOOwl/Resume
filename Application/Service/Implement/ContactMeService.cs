using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.SiteSide.ContactMe;
using Application.Service.Interface;
using Domain.Entities.ContactMe;
using Domain.RepositoryInterface;


namespace Application.Service.Implement
{
    public class ContactMeService : IContactMeService
    {
        private readonly IContactMeRepository _contactMeRepository;
        public ContactMeService(IContactMeRepository contactMeRepository)
        {
            _contactMeRepository = contactMeRepository;
        }

        public async Task AddNewContactMeMessage(ContactMeDTO contactMeDTO)
        {
            //ObjectMapping
            ContactMe model = new ContactMe()
            {
                FullName = contactMeDTO.FullName,
                Mobile = contactMeDTO.Mobile,
                Message = contactMeDTO.Message,
            };
            // Add To DataBase
            await _contactMeRepository.AddContactMeToDataBase(model);
        }
    }
}
