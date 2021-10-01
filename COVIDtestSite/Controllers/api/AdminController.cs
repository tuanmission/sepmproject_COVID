using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVIDtestSite.Data;
using COVIDtestSite.Models;
using COVIDtestSite.Models.DTO;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace COVIDtestSite.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AdminController : ControllerBase
    {
        private covidTestSiteDBContext _ctxt;
        private readonly IMapper mapper;
        public AdminController(covidTestSiteDBContext context, IMapper mpr)
        {
            this._ctxt = context;
            this.mapper = mpr;
        }

        [HttpGet]
        [Route("patientqueue/{id}")]
        public IEnumerable<CheckInDTO> returnpatientQueue(int id)
        {
            return _ctxt.checkins.Where(m =>m.TestingSiteId == id).ToList().Select(mapper.Map<checkin, CheckInDTO>);
        }

        [HttpGet]
        public IEnumerable<TestSiteDTO> getTestSites()
        {
            return _ctxt.TestingSites.Include(m => m.Provider).ToList().Select(mapper.Map<TestingSite, TestSiteDTO>);
        }
    }
}
