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
    public class AddressManager : GenericManager<Address, DtoAddress>, IAddressService
    {
        public readonly IAddressRepository addressRepository;
        public AddressManager(IServiceProvider service) : base(service)
        {
        }
    }
}
