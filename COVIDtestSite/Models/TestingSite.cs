using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace COVIDtestSite.Models
{
    public partial class TestingSite
    {
        public int Id { get; set; }

        [Display(Name ="Test Site Name")]
        public string TestSiteName { get; set; }

        
    

      
   
        [Required]
        [ForeignKey("Provider")]
        public int? ProviderId { get; set; }

       
        public string WaitingTime { get; set; }
        
        public decimal latitude { get; set; }

        public decimal longitude { get; set; }


        
        [Required]
        [ForeignKey("TestsiteType")]
        public int? TestsiteTypeId { get; set; }

        public string Address { get; set; }

     
      
        public virtual Provider Provider { get; set; }

        
        public virtual TestsiteType TestsiteType { get; set; }
    }
}
