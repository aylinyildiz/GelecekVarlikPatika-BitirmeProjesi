using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SiteManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Dal.Concrete.Entityframework.Context
{
    public class SiteManagementContext : DbContext
    {
        IConfiguration configuration;
        public SiteManagementContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public  DbSet<Invoice> Invoices { get; set; }
        public  DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public  DbSet<Role> Roles { get; set; }
        public  DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        }
    }
}
