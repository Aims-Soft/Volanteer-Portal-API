
namespace UMISModuleAPI.Entities
{
    public class SaveApplicantUser
    {
        public int  applicantVolunteerID  { get; set; }  
        // public string appliedDate { get; set; }
        // public string startDate { get; set; }
        public int userID { get; set; }
        public int incidentID {get; set;}
        public string spType { get; set; }    
    }
}