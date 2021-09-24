using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDtestSite.Models.DTO
{
    public class ProviderDTO
    {


        public int Id { get; set; }
        public string ProviderName { get; set; }
        public int? MedicareNo { get; set; }
        public string Service { get; set; }
        public int? AccreditationNo { get; set; }

    }
}
