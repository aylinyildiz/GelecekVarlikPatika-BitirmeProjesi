using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SiteManagement.Dal.Abstract;
using SiteManagement.Entity.Base;
using SiteManagement.Entity.Dto;
using SiteManagement.Entity.IBase;
using SiteManagement.Entity.Models;
using SiteManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Bll
{
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;
        private IConfiguration configuration;

        public UserManager(IServiceProvider service) : base(service)
        {
            userRepository = service.GetService<IUserRepository>();
        }

        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));


            if (user != null)
            {
                var dtoUser= ObjectMapper.Mapper.Map<DtoLoginUser>(user);
                var token = new TokenManager(configuration).CreateAccessToken(dtoUser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoUser,
                    AccessToken = token
                };

                return new Response<DtoUserToken>
                {
                    Message = "Token üretildi",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoUserToken>
                {
                    Message = "Email veya parolanız yanlış!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
