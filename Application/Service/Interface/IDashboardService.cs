using Application.DTOs.SiteSide.Home_Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Interface
{
    public interface IDashboardService
    {
        Task<HomeIndexModelDTO> FillDashboardModel();
    }
}
