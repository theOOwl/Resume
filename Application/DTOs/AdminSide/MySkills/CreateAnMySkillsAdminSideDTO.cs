using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AdminSide.MySkills
{
    public class CreateAnMySkillsAdminSideDTO
    {
        [Required]
        public string SkillTille { get; set; }

        [Required]
        public int Percentage { get; set; }
    }
}
