using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class GetSkills
    {
        public int categoryID { get; set; }
        public string categoryTitle { get; set; }
        public string domain { get; set; }
   }
}