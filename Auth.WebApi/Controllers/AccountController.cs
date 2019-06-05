using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Auth.WebApi.DTOs;
using AutoMapper;
using EFCore.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Auth.WebApi.Attributes;
using System.Net.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using EFCore.Entities;

namespace Auth.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IMapper mapper;
        IUserDataService service;
        public AccountController(IMapper mapper, IUserDataService service)
        {
            this.mapper = mapper;
            this.service = service;
        }
        // GET: api/Account
        [HttpGet]
        [ApiAuthorize]
        public IActionResult Get()
        {
            var result = service.FindAllUser();
            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(result));
        }

        [HttpGet]
        [Route("FetchToken")]
        public IActionResult FetchToken(string username, string password)
        {

            // Define const Key this should be private secret key  stored in some safe place
            string key = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";

            // Create Security key  using private key above:
            // not that latest version of JWT using Microsoft namespace instead of System
            var securityKey = new Microsoft
               .IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            // Also note that securityKey length should be >256b
            // so you have to make sure that your private key has a proper length
            //
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                              (securityKey, SecurityAlgorithms.HmacSha256Signature);

            //  Finally create a Token
            var header = new JwtHeader(credentials);

            //Some PayLoad that contain information about the  customer
            var payload = new JwtPayload
           {
               { "username ", "Sangeeta"},
               { "role", "admin"},
               { "claims", "read,write,update,delete"}
           };

            //
            var secToken = new JwtSecurityToken(header, payload);

            var handler = new JwtSecurityTokenHandler();

            // Token to String so you can use it in your client
            var tokenString = handler.WriteToken(secToken);

            var result = new { Code = HttpStatusCode.OK, Token = Encryption.Crypt(tokenString) };

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(result));
        }

        // GET: api/Account/5

        [HttpGet("{username}", Name = "Get")]
        [ApiAuthorize]
        public IActionResult Get(string username)
        {
            var result = service.FindUserByUserName(username);
            UserDTO user = mapper.Map<UserDTO>(result.Result);
            user.UserRoles = new List<string>();
            user.UserRoles.Add(service.GetUserRoleId(result.Result.Id.ToString()));

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(user));
        }

        // POST: api/Account
        [HttpPost]
        [ApiAuthorize]
        public IActionResult Post([FromBody] UserDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = service.AddUser(mapper.Map<User>(user), user.UserRoles);

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(result.Result));
        }

        // PUT: api/Account/5
        [HttpPut("{id}")]
        [ApiAuthorize]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ApiAuthorize]
        public void Delete(int id)
        {
        }
    }
}
