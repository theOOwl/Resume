using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AdminSide.Experience
{
    public class ListOFAnExperienceAdminSideDTO
    {
        #region properties

        public int Id { get; set; }
        public string ExperienceTitle { get; set; }
        public string ExperienceDuration { get; set; }
        public string? CompanySite { get; set; }
        public string CompanyName { get; set; }
        public string? Description { get; set; }


        #endregion
    }
}
