using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AdminSide.Education
{
    public class CreateAnEducationAdminSideDTO
    {
        [Required]
        public string EducationTitle { get; set; }

        [Required]
        public string EducationDuration { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
