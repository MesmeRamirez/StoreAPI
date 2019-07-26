using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using ModelStoreAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AuthenticationStoreAPI.Services
{
    public class ProfileService : IProfileService
    {
        protected UserManager<CUser> _userManager;

        public ProfileService(UserManager<CUser> userManager)
        {
            _userManager = userManager;
        }

        public Task GetProfileDataAsync(ProfileDataRequestContext context)//Obtener la info del user
        {
            var user = _userManager.GetUserAsync(context.Subject).Result;

            var claims = new List<Claim>
            {
                new Claim("UserName", user.UserName ?? ""),
                new Claim(ClaimTypes.Uri, user.UserURL ?? ""),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Surname, user.LastName)
    };

            context.IssuedClaims.AddRange(claims);

            return Task.FromResult(0);

            //throw new NotImplementedException(); 
        }

        public Task IsActiveAsync(IsActiveContext context)//Validar si esta activo o no el user
        {
            var user = _userManager.GetUserAsync(context.Subject).Result;
            context.IsActive = true;
            return Task.FromResult(0);
        }
    }
}
