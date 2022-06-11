using SiteManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Models
{
    public class InvoiceType : EntityBase
    {
        public int Id { get; set; }
        public string Type { get; set; } //doğalgaz,su,elektrik

        public Invoice Invoice { get; set; }
    }
}
