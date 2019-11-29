using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiRest.Rest.Api.Models;
using AutoMapper;
using ApiRest.Entities.Models;
using ApiRest.BussinessLogic.BussinessObjects;

namespace ApiRest.Rest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserController(IUserRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET api/user
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            List<UserDTO> models = null;
            try
            {
                var users = await _repository.Get();
                models = _mapper.Map<List<User>, List<UserDTO>>(users);
                if (models == null) return NotFound();
                return Ok(models);
            }
            catch (Exception)
            {
                models = new List<UserDTO>();
                return BadRequest(models);
            }
        }
    }
}
