using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVIDtestSite.Models;

namespace COVIDtestSite.ViewModels
{
    public class EditViewModel
    {

        public int Id { get; set; }
        public string TestSiteName { get; set; }
        public int? ProviderId { get; set; }
        public string WaitingTime { get; set; }

        public decimal latitude { get; set; }

        public decimal longitude { get; set; }
        public int? TestsiteTypeId { get; set; }
        public string Address { get; set; }

        public List<TestsiteType> testsites { get; set; }
        public List<Provider> providers { get; set; }

    }
}
