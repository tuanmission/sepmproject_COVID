using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COVIDtestSite.Models
{
    public class checkin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string name { get; set; }
        public string medicareNumber { get; set; }

        public string phoneNumber { get; set; }

        public string address { get; set; }
        public int TestingSiteId { get; set; }

        [ForeignKey("TestingSiteId")]
        public TestingSite testsite { get; set; }
    }
}
