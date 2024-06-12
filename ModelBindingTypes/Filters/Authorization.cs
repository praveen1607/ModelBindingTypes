using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace ModelBindingTypes.Filters
{
    public class Authorization : IAuthorizationFilter
    {
        private readonly string _role;

        public Authorization(string role)
        {
            _role = "Admin";
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("8a3c7393fc3b9d70d73f75d5e1e6b4f3");

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;


                var username = jwtToken.Claims.First(x => x.Type == JwtRegisteredClaimNames.Sub).Value;
                var roles = jwtToken.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).ToList();

                if (!roles.Contains(_role))
                {
                    context.Result = new ForbidResult();
                }
            }
            catch (Exception ex)
            {
                
                context.Result = new UnauthorizedResult();
            }

        }
    }
}
