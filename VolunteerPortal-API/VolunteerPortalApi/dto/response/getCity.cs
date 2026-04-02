
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class GetCity
    {
        public int cityID { get; set; }
        public int provinceID { get; set; }
        public string cityName { get; set; }
    }
}
