using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVIDtestSite.Data;
using COVIDtestSite.Models;
using COVIDtestSite.Models.DTO;
using COVIDtestSite.MapProfiles;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace COVIDtestSite.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TestSiteController : ControllerBase
    {

        private covidTestSiteDBContext _ctxt;

        private readonly IMapper mapper;
        public TestSiteController(covidTestSiteDBContext context, IMapper mper)
        {
            this._ctxt = context;
            this.mapper= mper;
        }


        [HttpGet]
        [Route("testsitedetails/{id}")]

        public ActionResult<TestSiteDTO> getTestSiteDetails(int id)
        {
            var testsite = _ctxt.TestingSites.Include(m => m.TestsiteType).Include(m => m.Provider).SingleOrDefault(m => m.Id == id);
            if (testsite == null)
            {
                return NotFound();
            }

            var returnDTO = mapper.Map<TestingSite, TestSiteDTO>(testsite);
            return returnDTO;
        }



       
        

       
    }
}
