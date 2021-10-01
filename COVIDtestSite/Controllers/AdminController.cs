using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVIDtestSite.Data;
using COVIDtestSite.ViewModels;
using COVIDtestSite.Models;

namespace COVIDtestSite.Controllers
{
    public class AdminController : Controller
    {
        private covidTestSiteDBContext _ctxt;
        public AdminController( covidTestSiteDBContext context)
        {
            this._ctxt = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTestSite()
        {
            var providers = _ctxt.Providers.ToList();
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

        public IActionResult patientqueue(int id)

        {

            QueueViewModel mdl = new QueueViewModel
            {
                TestSiteId = id
            };
            
            return View(mdl);
        }

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
