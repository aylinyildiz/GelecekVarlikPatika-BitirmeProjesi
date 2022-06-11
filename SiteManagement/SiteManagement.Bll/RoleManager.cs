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
    public class RoleManager : GenericManager<Role, DtoRole>, IRoleService
    {
        public readonly IRoleRepository roleRepository;
        public RoleManager(IServiceProvider service) : base(service)
        {

        }
    }
}
