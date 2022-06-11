﻿using SiteManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Models
{
    public class User : EntityBase
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? VehicleNumber { get; set; }
        public Apartment Apartment { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
