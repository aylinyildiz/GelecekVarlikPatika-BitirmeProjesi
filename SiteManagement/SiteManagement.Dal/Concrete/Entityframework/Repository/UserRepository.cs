using Microsoft.EntityFrameworkCore;
using SiteManagement.Dal.Abstract;
using SiteManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Dal.Concrete.Entityframework.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }

        public User Login(User login)
        {
            var user = dbset.Where(x => x.Email == login.Email && x.Password == login.Password).SingleOrDefault();

            return user;
        }
    }
}
