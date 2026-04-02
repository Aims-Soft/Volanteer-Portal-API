
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class DashboardCount
    {
        public int TotalVolunteers { get; set; }
        public int TotalIncidents { get; set; }
        public int ActiveIncidents { get; set; }
        public int  ActiveVolunteers { get; set; }
    }
}