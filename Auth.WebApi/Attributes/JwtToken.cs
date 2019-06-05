using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.WebApi.Attributes
{
    public class JwtToken
    {

        public static TokenDetails ReadJwtToken(string jwtToken) //, out string userClaims, out string sessionId, out string userName, out DateTime validTo)
        {
            var jwtHandler = new JwtSecurityTokenHandler();

            if (jwtHandler.CanReadToken(jwtToken))
            {
                var tokenValue = jwtHandler.ReadJwtToken(jwtToken);

                var claims = tokenValue.Claims;

                var result = new TokenDetails
                {

                    ClaimsJson = claims.First(c => c.Type == "claims").Value,

                    SessionId = claims.First(c => c.Type == "sessionid").Value,

                    ValidTo = tokenValue.ValidTo,

                    Username = claims.First(c => c.Type == JwtRegisteredClaimNames.NameId).Value
                };
                return result;
            }
            return null;
        }
    }

    public class TokenDetails
    {
        public string ClaimsJson { get; set; }
        public string SessionId { get; set; }
        public DateTime ValidTo { get; set; }
        public string Username { get; set; }
    }

}
