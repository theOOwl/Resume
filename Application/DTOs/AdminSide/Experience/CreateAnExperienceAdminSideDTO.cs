using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AdminSide.Experience
{
    public class CreateAnExperienceAdminSideDTO
    {
        [Required]
        public string ExperienceTitle { get; set; }

        [Required]
        public string ExperienceDuration { get; set; }

        [Required]
        public string? CompanySite { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
