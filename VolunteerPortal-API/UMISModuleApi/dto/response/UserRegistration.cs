using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
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
        public int physicallyFit { get; set; }
        public int age { get; set; }
        public int genderID { get; set; }
        public string genderName { get; set; }
        public int degreeID { get; set; }
        public string degreeName { get; set; }
        public int experienceID { get; set; }
        public string experienceTitle { get; set; }
    }
}