using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using COVIDtestSite.Models;

namespace COVIDtestSite.ViewModels
{
    public class AddTestSiteViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Test Site Name")]
        [Required]
        public string TestSiteName { get; set; }




        [Required]
        public int? ProviderId { get; set; }


        public string WaitingTime { get; set; }

        

        [Required]
        public int? TestsiteTypeId { get; set; }

        [Required]
        public string Address { get; set; }

        public decimal lattitude { get; set; }
        public decimal longitude { get; set; }

        public List<Provider> providers { get; set; }

        public List<TestsiteType> testsitetypes { get; set; }

    }
}
