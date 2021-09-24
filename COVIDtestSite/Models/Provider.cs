using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDtestSite.Models
{
    public partial class Provider
    {
        public Provider()
        {
            TestingSites = new HashSet<TestingSite>();
        }

        public int Id { get; set; }
        public string ProviderName { get; set; }
        public int? MedicareNo { get; set; }
        public string Service { get; set; }
        public int? AccreditationNo { get; set; }

        public virtual ICollection<TestingSite> TestingSites { get; set; }
    }
}
