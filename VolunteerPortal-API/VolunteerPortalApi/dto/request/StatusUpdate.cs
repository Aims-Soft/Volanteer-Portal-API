using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class StatusUpdate
    {
        public int incidentID { get; set; }
        public string incidentTitle { get; set; }
        public int status { get; set; }
        public int userID { get; set; }
        public string spType { get; set; }
    }
}