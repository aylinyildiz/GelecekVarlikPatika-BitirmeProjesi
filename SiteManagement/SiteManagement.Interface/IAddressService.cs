using SiteManagement.Entity.Dto;
using SiteManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Interface
{
    public interface IAddressService : IGenericService<Address, DtoAddress>
    {
        //IQueryable<DtoAddress> GetTotalReport();
    }
}
