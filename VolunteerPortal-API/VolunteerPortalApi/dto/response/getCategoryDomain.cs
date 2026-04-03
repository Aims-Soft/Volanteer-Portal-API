
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class CategoryDoamin
    {
        public int categoryID { get; set; }
        public string categoryTitle { get; set; }
        public int domainID { get; set; }
        public string domainTitle { get; set; }
    }
}