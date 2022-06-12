﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SiteManagement.Entity.Dto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Bll
{
    public class TokenManager
    {
        IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string CreateAccessToken(DtoLoginUser user)
        {
            //claim
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, user.Id.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            //claim rol
            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
                new Claim("role2", "User")
            };

            //security key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            //şifrelenmiş kimlik oluşturmak
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //token ayarları 
            var token = new JwtSecurityToken
            (
                issuer: configuration["Tokens:Issuer"], 
                audience: configuration["Tokens:Issuer"], 
                expires: DateTime.Now.AddDays(1), 
                notBefore: DateTime.Now, 
                signingCredentials: cred, 
                claims: claimsIdentity.Claims 
            );

            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };
            return tokenHandler.token;

        }
    }
}
