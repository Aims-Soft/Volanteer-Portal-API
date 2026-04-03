using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class SaveIncident
    {
        public int incidentID { get; set; }
        public string incidentTitle { get; set; }
        public string description { get; set; }
        public int volunteerNeeded { get; set; }
        public string location { get; set; }
        public string date { get; set; }
        public int cityID { get; set; }
        public int priortyID { get; set; }
        public string eDoc { get; set; }
        public string eDocPath { get; set; }
        public string eDocExt { get; set; }
        public int userID { get; set; }
        public string json {get; set;}
        public string spType { get; set; }
    }
}