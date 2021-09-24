using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVIDtestSite.Data;
using Microsoft.EntityFrameworkCore;
using COVIDtestSite.ViewModels;
using COVIDtestSite.Models;

namespace COVIDtestSite.Controllers
{
    public class TestSiteController : Controller
    {

        private covidTestSiteDBContext _ctxt;

        public TestSiteController(covidTestSiteDBContext context)
        {
            this._ctxt = context;
        }
        public IActionResult Index()
        {
            var testsites = _ctxt.TestingSites.Include(m => m.TestsiteType).ToList();
            var viewModel = new TestSiteViewModel
            {

                testingSites = testsites
            };
            return View(viewModel);
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

        [Route("TestSite/details/{id}")]
        public IActionResult TestSiteDetails(int id)
        {
            var viewmodel = new TestSiteDetailViewModel
            {

                Id=id

            };
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Save(AddTestSiteViewModel mdl)

        {

            TestingSite ts = new TestingSite
            {
                Address = mdl.Address,
                TestSiteName = mdl.TestSiteName,
                WaitingTime = "0",
                ProviderId = mdl.ProviderId,
                TestsiteTypeId = mdl.TestsiteTypeId

            };
            _ctxt.TestingSites.Add(ts);
            _ctxt.SaveChanges();
            return RedirectToAction("Index", "TestSite");
        }

  
        
    }
}
