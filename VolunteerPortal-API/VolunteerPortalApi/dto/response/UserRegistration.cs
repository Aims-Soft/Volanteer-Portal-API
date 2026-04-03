
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class UserRegistration
    {
        public int userID { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string contactNo { get; set; }
        public string cnic { get; set; }
        public string address { get; set; }
        public string createdOn { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int provinceID { get; set; }
        public string provinceName { get; set; }
        public int domainID { get; set; }
        public string domainTitle { get; set; }
    }
}