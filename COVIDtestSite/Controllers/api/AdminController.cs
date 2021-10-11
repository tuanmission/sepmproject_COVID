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
using Microsoft.AspNetCore.Identity;
using AutoMapper;

namespace COVIDtestSite.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AdminController : ControllerBase
    {
        private covidTestSiteDBContext _ctxt;
        private UserManager<IdentityUser> _appmgr;
        private readonly IMapper mapper;
        public AdminController(covidTestSiteDBContext context, IMapper mpr, UserManager<IdentityUser> appmanager)
        {
            this._ctxt = context;
            this.mapper = mpr;
            this._appmgr = appmanager;
        }

        [HttpGet]
        [Route("patientqueue/{id}")]
        public IEnumerable<CheckInDTO> returnpatientQueue(int id)
        {
            return _ctxt.checkins.Where(m =>m.TestingSiteId == id).ToList().Select(mapper.Map<checkin, CheckInDTO>);
        }

        [HttpGet]
        public async Task <IEnumerable<TestSiteDTO>> getTestSites()
        {
           if (User.IsInRole(Roles.registereduser))
            {
                var user = await _appmgr.GetUserAsync(User);
                ApplicationUser usr = await _ctxt.ApplicationUsers.SingleOrDefaultAsync(m => m.Id == user.Id);
                return _ctxt.TestingSites.Include(m => m.Provider).Where(m=> m.ProviderId == usr.ProviderId).ToList().Select(mapper.Map<TestingSite, TestSiteDTO>);
            } 
            return _ctxt.TestingSites.Include(m => m.Provider).ToList().Select(mapper.Map<TestingSite, TestSiteDTO>);
        }
    }
}
