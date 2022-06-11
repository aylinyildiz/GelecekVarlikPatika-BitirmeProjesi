using SiteManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Models
{
    public class Role : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
