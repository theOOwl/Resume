using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AdminSide.Education
{
    public class ListOFAnExperienceAdminSideDTO
    {
        #region properties

        public int Id { get; set; }

        public string EducationTitle { get; set; }

        public string EducationDuration { get; set; }
        public string? Description { get; set; }


        #endregion
    }
}
