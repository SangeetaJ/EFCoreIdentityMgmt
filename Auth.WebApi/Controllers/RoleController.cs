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
using Microsoft.AspNetCore.Authorization;
using Auth.WebApi.Attributes;
using System.Net.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Auth.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        IMapper mapper;
        IUserDataService service;
        public RoleController(IMapper mapper, IUserDataService service)
        {
            this.mapper = mapper;
            this.service = service;
        }

        [HttpGet]
        [ApiAuthorize]
        public IActionResult Get()
        {
            var result = service.GetAllRoles();

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(result));
        }
    }
}