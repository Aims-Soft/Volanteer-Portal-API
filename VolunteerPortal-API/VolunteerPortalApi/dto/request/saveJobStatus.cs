using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class SaveJobStatus
    {
        public int userID { get; set; }
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public int jobStatusID { get; set; }
        public string spType { get; set; }
    }
}