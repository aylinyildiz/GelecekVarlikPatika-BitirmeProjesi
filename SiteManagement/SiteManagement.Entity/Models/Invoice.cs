using SiteManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Models
{
    public class Invoice : EntityBase
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

        public int InvoiceTypeId { get; set; }
        public InvoiceType InvoiceType { get; set; }
    }
}
