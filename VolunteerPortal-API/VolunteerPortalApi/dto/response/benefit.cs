
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class RecentCrises
    {
        public int incidentID { get; set; }
        public string incidentTitle { get; set; }
        public int priortyTypeID { get; set; }
        public string priortyTypeTitle { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int provinceID { get; set; }
        public string provinceName { get; set; }
    }
}