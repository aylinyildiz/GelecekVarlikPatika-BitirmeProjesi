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
    public class InvoiceTypeManager : GenericManager<InvoiceType, DtoInvoiceType>, IInvoiceTypeService
    {
        public readonly IInvoiceTypeRepository invoiceTypeRepository;

        public InvoiceTypeManager(IServiceProvider service) : base(service)
        {
        }
    }
}
