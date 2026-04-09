using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class DashboardIncidents
    {
        public string incidentTitle { get; set; }
        public string cityName { get; set; }
        public string provinceName { get; set; }
        public int status { get; set; }
    }
}