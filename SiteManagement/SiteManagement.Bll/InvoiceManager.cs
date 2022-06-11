using SiteManagement.Dal.Abstract;
using SiteManagement.Entity.Dto;
using SiteManagement.Entity.Models;
using SiteManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Bll
{
    public class InvoiceManager : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        public readonly IInvoiceRepository invoiceRepository;
        public InvoiceManager(IServiceProvider service) : base(service)
        {
        }
    }
}
