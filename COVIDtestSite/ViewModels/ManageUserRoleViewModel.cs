using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVIDtestSite.Models;
using Microsoft.AspNetCore.Identity;

namespace COVIDtestSite.ViewModels
{
    public class ManageUserRoleViewModel
    {
        public IList<IdentityUser> currentUsers;

        public List<string> roles;
    }
}
