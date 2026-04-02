
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class GetProvince
    {
        public int provinceID { get; set; }
        public string provinceName { get; set; }
        public int countryID { get; set; }
    }
}
