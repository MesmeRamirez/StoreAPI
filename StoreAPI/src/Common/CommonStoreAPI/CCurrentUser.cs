using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace CommonStoreAPI
{
    public interface ICurrentUser
    {
        CurrentUser Get { get; }
    }

    public class CCurrentUser : ICurrentUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CCurrentUser(IHttpContextAccessor httpContextAccessor)
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

                if (claims.Any(x => x.Type.Equals(ClaimTypes.Email)))
                {
                    result.Email = claims.Where(x => x.Type.Equals(ClaimTypes.Email)).First().Value;
                }

                if (claims.Any(x => x.Type.Equals("ImageProfile")))
                {
                    result.Image = claims.Where(x => x.Type.Equals("ImageProfile")).First().Value;
                }

                if (claims.Any(x => x.Type.Equals("access_token")))
                {
                    result.Token = claims.Where(x => x.Type.Equals("access_token")).First().Value;
                }

                return result;
            }
        }
    }    

    public class CurrentUser
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
    }
}
