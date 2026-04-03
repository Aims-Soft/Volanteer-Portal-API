using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class SaveConfigration
    {
        public int categoryID { get; set; }
        public int domainID { get; set; }
        public string domainTitle { get; set; }
        public int userID { get; set; }
        public string spType { get; set; }
    }
}