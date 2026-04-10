using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerPortalApi.Entities
{
    public class GetProvinceCount
    {
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int provinceID { get; set; }
        public string provinceName { get; set; }
        public int TotalIncidents { get; set; }
    }
}