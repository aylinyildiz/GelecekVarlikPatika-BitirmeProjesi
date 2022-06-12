using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteManagement.Entity.Base;
using SiteManagement.Entity.Dto;
using SiteManagement.Entity.IBase;
using SiteManagement.Entity.Models;
using SiteManagement.Interface;
using SiteManagement.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiBaseController<IUserService, User, DtoUser>
    {
        private IUserService userService;
        public UserController(IUserService userService) :base(userService)
        {
            this.userService = userService;
        }

        [HttpPost("Login")]
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {

            try
            {
                return userService.Login(login);
            }
            catch (Exception ex)
            {
                return new Response<DtoUserToken>
                {
                    Message = "Error:" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }

        }


    }
}
