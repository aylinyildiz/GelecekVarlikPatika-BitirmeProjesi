using SiteManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Dto
{
    public class DtoInvoiceType : DtoBase
    {
        public int Id { get; set; }
        public string Type { get; set; } 

    }
}
