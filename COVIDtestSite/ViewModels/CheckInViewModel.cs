using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDtestSite.ViewModels
{
    public class CheckInViewModel
    {

        public int Id { get; set; }
        public string name { get; set; }
        public string medicareNumber { get; set; }

        public string phoneNumber { get; set; }

        public string address { get; set; }
        public int TestingSiteId { get; set; }
    }
}
