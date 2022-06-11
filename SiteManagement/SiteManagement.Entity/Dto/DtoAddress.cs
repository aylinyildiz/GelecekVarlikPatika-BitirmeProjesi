using SiteManagement.Entity.Base;
using SiteManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Dto
{
    public class DtoAddress : DtoBase
    {
        public int Id { get; set; }
        public string AddressInfo { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public Apartment Apartment { get; set; }
    }
}
