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
         
            return View();
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

     
        public IActionResult CheckIn(int id)
        {
            var viewmodel = new CheckInViewModel
            {
                TestingSiteId = id
            };
            return View(viewmodel);
        }

        

        public IActionResult checkinsave(CheckInViewModel mdl)
        {
            checkin cs = new checkin
            {
                name = mdl.name,
                medicareNumber = mdl.medicareNumber,
                address = mdl.address,
                phoneNumber = mdl.phoneNumber,
                TestingSiteId = mdl.TestingSiteId

            };
            _ctxt.checkins.Add(cs);
            _ctxt.SaveChanges();
            return RedirectToAction("TestSiteDetails", "TestSite", new { id = mdl.TestingSiteId });
        }

  
        
    }
}
