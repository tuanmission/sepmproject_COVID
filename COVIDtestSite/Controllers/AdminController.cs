using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVIDtestSite.Data;
using COVIDtestSite.ViewModels;
using COVIDtestSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;


namespace COVIDtestSite.Controllers
{
    public class AdminController : Controller
    {
        private covidTestSiteDBContext _ctxt;
        private UserManager<IdentityUser> _mgr;
        
        public AdminController( covidTestSiteDBContext context, UserManager<IdentityUser> manager)
        {
            this._ctxt = context;
            this._mgr = manager;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles=Roles.admin)]
        public async Task <IActionResult> ManageUserRoles()
        {
            IList<IdentityUser> adminusers = await _mgr.GetUsersInRoleAsync(Roles.admin);
            var user = await _mgr.GetUserAsync(User);
            if (adminusers.Contains(user))
            {
                adminusers.Remove(user);
            }
            ManageUserRoleViewModel mdl = new ManageUserRoleViewModel
            {
                currentUsers = adminusers
            };
            return View(mdl);
            
        }
      

        [Authorize(Roles = Roles.admin)]
        public async   Task<IActionResult> ConfigureUsers()
        {
            IList<IdentityUser> registeredUsers = await _mgr.GetUsersInRoleAsync(Roles.registereduser);
            var user = await _mgr.GetUserAsync(User);
            if (registeredUsers.Contains(user))
            {
                registeredUsers.Remove(user);
            }
            ConfigureUserViewModel mdl = new ConfigureUserViewModel
            {
                users = registeredUsers
            };
            return View(mdl);
        }

        

        public async Task<IActionResult> addUsertoAdmin(string userId)
        {
            IdentityUser usr = await _mgr.FindByIdAsync(userId);
            await _mgr.AddToRoleAsync(usr, Roles.admin);
            await _mgr.RemoveFromRoleAsync(usr, Roles.registereduser);
            return RedirectToAction("ManageUserRoles", "Admin");


        }


        public async Task<IActionResult> RemoveUserfromAdmin(string userId)
        {
            IdentityUser usr = await _mgr.FindByIdAsync(userId);
            await _mgr.RemoveFromRoleAsync(usr, Roles.admin);
            await _mgr.AddToRoleAsync(usr, Roles.registereduser);
            return RedirectToAction("ManageUserRoles", "Admin");


        }


        [Authorize]

        public async Task <IActionResult> AddTestSite()
        {
            
            List<Provider> providers = new List<Provider>();
            
             if (User.IsInRole(Roles.registereduser))
            {
                var user = await _mgr.GetUserAsync(User);
                ApplicationUser usr = _ctxt.ApplicationUsers.FirstOrDefault(m => m.Id == user.Id);
                providers = _ctxt.Providers.Where(m => m.Id == usr.ProviderId).ToList();
            }
            else
            {
                providers = _ctxt.Providers.ToList();
            }
            
            var testsitetypes = _ctxt.TestsiteTypes.ToList();
            AddTestSiteViewModel viewModel = new AddTestSiteViewModel
            {
                providers = providers,
                testsitetypes = testsitetypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult add(AddTestSiteViewModel mdl)

        {

            TestingSite ts = new TestingSite
            {
                Address = mdl.Address,
                TestSiteName = mdl.TestSiteName,
                WaitingTime = "0",
                ProviderId = mdl.ProviderId,
                TestsiteTypeId = mdl.TestsiteTypeId,
                latitude = mdl.lattitude,
                longitude = mdl.longitude


            };
            _ctxt.TestingSites.Add(ts);
            _ctxt.SaveChanges();
            return RedirectToAction("List", "Admin");
        }

        [Route("Admin/edit/{id}")]
        public IActionResult edit(int id)
        {
            var currenttestsite = _ctxt.TestingSites.SingleOrDefault(m => m.Id == id);
            var TestSitetypes = _ctxt.TestsiteTypes.ToList();
            var providers = _ctxt.Providers.ToList() ;

            var viewMdl = new EditViewModel
            {
                Id = currenttestsite.Id,
                TestSiteName = currenttestsite.TestSiteName,
                ProviderId = currenttestsite.ProviderId,
                WaitingTime = currenttestsite.WaitingTime,
                latitude = currenttestsite.latitude,
                longitude = currenttestsite.longitude,
                TestsiteTypeId = currenttestsite.TestsiteTypeId,
                Address = currenttestsite.Address,
                testsites = TestSitetypes,
                providers = providers

            };



            return View(viewMdl);
        }

        [Authorize]
        public IActionResult patientqueue(int id)

        {

            QueueViewModel mdl = new QueueViewModel
            {
                TestSiteId = id
            };
            
            return View(mdl);
        }

        [Authorize]
        public IActionResult List()
        {
            return View();
        }


        public IActionResult save(EditViewModel mdl)
        {
            var testsite = _ctxt.TestingSites.SingleOrDefault(m => m.Id == mdl.Id);
            testsite.Id = mdl.Id;
            testsite.TestSiteName = mdl.TestSiteName;
            testsite.ProviderId = mdl.ProviderId;
            testsite.WaitingTime = mdl.WaitingTime;
            testsite.latitude = mdl.latitude;
            testsite.longitude = mdl.longitude;
            testsite.TestsiteTypeId = mdl.TestsiteTypeId;
            testsite.Address = mdl.Address;

            _ctxt.SaveChanges();
            return RedirectToAction("List", "Admin");
        }


    }
}
