using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalAppAPI.Data;
using LocalAppAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocalAppAPI.Controllers
{
    
    [Route("api/local")]
    [ApiController]
    public class LocalController : ControllerBase
    {
        private readonly ILocalRepository _localRepository;

        public LocalController(ILocalRepository localRepository)
        {
            _localRepository = localRepository;
        }

        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Local>> GetAllDetails()
        {
            var locals = _localRepository.GetAllDetails();

            return Ok(locals);
        }

        //GET api/commands/{id}
        [HttpGet("{name}")]
        public ActionResult<Local> GetCommandById(string name)
        {
            var local = _localRepository.GetDetailsByName(name);
            return Ok(local);
        }
    }
}
