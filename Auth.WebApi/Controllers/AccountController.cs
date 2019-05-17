using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Auth.WebApi.DTOs;
using AutoMapper;
using static EFCore.Entities.IdnDBContext;
using EFCore.DataAccess;

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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Account/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Account
        [HttpPost]
        public IActionResult Post([FromBody] UserDTO user)
        {
            var result = service.AddUser(mapper.Map<User>(user));

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(result.Result));
        }

        // PUT: api/Account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
