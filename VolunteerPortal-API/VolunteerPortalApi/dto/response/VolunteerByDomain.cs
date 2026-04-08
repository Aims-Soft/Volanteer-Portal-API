
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class VolunteerByDomain
    {
        public int Volunteer { get; set; }
        public int domainID { get; set; }
        public string domainTitle { get; set; }
    }
}