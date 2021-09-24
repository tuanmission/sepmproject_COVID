using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDtestSite.Models.DTO
{
    public class TestSiteDTO
    {
        public int Id { get; set; }
     
        public string TestSiteName { get; set; }
     
        public int? ProviderId { get; set; }

        public string WaitingTime { get; set; }

        public decimal latitude { get; set; }
        public decimal longitude { get; set; } 
        public int? TestsiteTypeId { get; set; }
        public string Address { get; set; }
        public virtual ProviderDTO Provider { get; set; }
        public virtual TestSiteTypeDTO TestsiteType { get; set; }
    }
}
