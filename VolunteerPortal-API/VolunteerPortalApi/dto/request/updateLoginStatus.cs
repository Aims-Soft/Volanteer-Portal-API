using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class LoginStatus
    {
        public int userID { get; set; }
        public string loginStatus { get; set; }
        public string spType { get; set; }
    }
}