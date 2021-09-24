using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using COVIDtestSite.Models;
using COVIDtestSite.Models.DTO;

namespace COVIDtestSite.MapProfiles
{
    public class mappingprofile : Profile
    {
        public mappingprofile()
        {
            CreateMap<ProviderDTO, Provider>();
            CreateMap<Provider, ProviderDTO>();
            CreateMap<TestSiteDTO, TestingSite>();
            CreateMap<TestingSite, TestSiteDTO>();
            CreateMap<TestsiteType, TestSiteTypeDTO>();
            CreateMap<TestSiteTypeDTO, TestsiteType>();

        }

    }
}
