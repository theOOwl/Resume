using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.SiteSide.Home_Index
{
    public class HomeIndexModelDTO
    {
        #region properties

        public List<Domain.Models.Entities.Education.Education> Educations { get; set; }

        public List<Domain.Models.Entities.Experience.Experience> Experience { get; set; }

        public List<Domain.Models.Entities.MySkills.MySkills> MySkills { get; set; }

        #endregion
    }
}
