using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDtestSite.Models
{
    public partial class TestsiteType
    {
        public TestsiteType()
        {
            TestingSites = new HashSet<TestingSite>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<TestingSite> TestingSites { get; set; }
    }
}
