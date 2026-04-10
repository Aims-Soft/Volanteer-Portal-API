using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class GetAllIncidents
    {
        public int incidentID { get; set; }    
        public string incidentTitle { get; set; }
        public string description { get; set; }
        public int volunteerNeeded { get; set; }
        public string location { get; set; }
        public string date { get; set; }
        public int status { get; set; }
        public string Domains { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int provinceID { get; set; }
        public string provinceName { get; set; }
        public int priortyTypeID { get; set; }
        public string priortyTypeTitle { get; set; }  
        public string eDoc { get; set; }     
    }
}