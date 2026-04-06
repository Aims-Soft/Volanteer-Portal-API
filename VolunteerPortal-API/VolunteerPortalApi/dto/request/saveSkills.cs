using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class SaveSkill
    {
        public int categoryID { get; set; }
        public string Json { get; set; }
        public int userID { get; set; }
        public string spType { get; set; }
    }
}