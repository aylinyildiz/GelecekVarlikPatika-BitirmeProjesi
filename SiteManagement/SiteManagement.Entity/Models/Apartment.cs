using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Block { get; set; }
        public string Status { get; set; } //Daire durumu dolu mu boş mu
        public string Type { get; set; } // daire tipi (2+1)
        public string DoorNo { get; set; }
        public int Dues { get; set; } // aidat

        public int UserId { get; set; }
        public User User { get; set; }
        public Invoice Invoice { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}
