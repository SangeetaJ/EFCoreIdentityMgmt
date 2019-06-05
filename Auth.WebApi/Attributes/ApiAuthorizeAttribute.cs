using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Auth.WebApi.Attributes
{
    public class ApiAuthorizeAttribute : AuthorizeAttribute , IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isAuthorized = false;
           
            var authorizationHeader = context.HttpContext.Request.Headers["Authorization"];
            
                   //authorizationHeader[0].Contains(" ", StringComparison.InvariantCultureIgnoreCase) &&
                   //authorizationHeader[0].Split(" ")[0].Equals("Bearer", StringComparison.InvariantCultureIgnoreCase)
            if (authorizationHeader.Any())
            {
                var token = Encryption.Decrypt(authorizationHeader);

                var jwtHandler = new JwtSecurityTokenHandler();

                if (jwtHandler.CanReadToken(token))
                {
                    isAuthorized = true;
                    var tokenValue = jwtHandler.ReadJwtToken(token);

                    var claims = tokenValue.Claims;
                    var identity = new ClaimsIdentity(claims, "Basic");
                    context.HttpContext.User = new ClaimsPrincipal(identity);
                }
            }
            else
            {
                context.Result = new ForbidResult();
                context.HttpContext.Response.Headers.Add("WWW-Authenticate", "Access-Denied");
            }
        }
    }
}
