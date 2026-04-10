
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class ApplicantUser
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string CNIC { get; set; }
        public string contactNo { get; set; }
        public string categoryTitle { get; set; }
        public string cityName { get; set; }
        public string provinceName { get; set; }
        public int incidentID { get; set; }
    }
}