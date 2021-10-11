using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace COVIDtestSite.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string RegistrationNo { get; set; }

        public string Title { get; set; }

        public int ProviderId { get; set; }

        [ForeignKey("ProviderId")]
        public Provider provider { get; set; }
    }
}
