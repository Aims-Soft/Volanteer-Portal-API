using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class MobileUserCreation
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string cnic { get; set; }
        public int genderID { get; set; }
        public int cityID { get; set; }
        public int countryID { get; set; }
        public int age { get; set; }
        public int physicallyFit { get; set; }
        public string contactNo { get; set; }
        public string address { get; set; }
        public string json { get; set; }
        public int roleID { get; set; }
        public int userTypeID { get; set; }
        public int degreeID { get; set; }
        public int experienceID { get; set; }
        public string spType { get; set; }
    }
}