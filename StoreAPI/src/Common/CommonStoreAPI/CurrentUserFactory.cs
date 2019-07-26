using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace CommonStoreAPI
{
    public interface ICurrentUserFactory
    {
        CurrentUser Get { get; }
    }

    public class CurrentUserFactory : ICurrentUserFactory
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserFactory(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public CurrentUser Get
        {
            get
            {
                var result = new CurrentUser();
                if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                {
                    return result;
                }

                var claims = _httpContextAccessor.HttpContext.User.Claims;

                if (claims.Any(x => x.Type.Equals("sub")))
                {
                    result.UserId = claims.Where(x => x.Type.Equals("sub")).First().Value;
                }

                if (claims.Any(x => x.Type.Equals("UserName")))
                {
                    result.UserName = claims.Where(x => x.Type.Equals("UserName")).First().Value;
                }

                if (claims.Any(x => x.Type.Equals(ClaimTypes.Name)))
                {
                    result.Name = claims.Where(x => x.Type.Equals(ClaimTypes.Name)).First().Value;
                }

                if (claims.Any(x => x.Type.Equals(ClaimTypes.Surname)))
                {
                    result.LastName = claims.Where(x => x.Type.Equals(ClaimTypes.Surname)).First().Value;
                }

                if (claims.Any(x => x.Type.Equals(ClaimTypes.Email)))
                {
                    result.Email = claims.Where(x => x.Type.Equals(ClaimTypes.Email)).First().Value;
                }

                if (claims.Any(x => x.Type.Equals("access_token")))
                {
                    result.Token = claims.Where(x => x.Type.Equals("access_token")).First().Value;
                }

                if (claims.Any(x => x.Type.Equals(ClaimTypes.NameIdentifier)))
                {
                    result.UserURL = claims.Where(x => x.Type.Equals(ClaimTypes.NameIdentifier)).First().Value;
                }

                if (claims.Any(x => x.Type.Equals(ClaimTypes.Role)))
                {
                    result.Role = claims.Where(x => x.Type.Equals(ClaimTypes.Role)).First().Value;
                }

                return result;
            }
        }
    }    

    public class CurrentUser
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserURL { get; set; }
        public string Role { get; set; }
    }
}
