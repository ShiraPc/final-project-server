using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskManageent.BL;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.net_core_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteersController : ControllerBase
    {
        volunteerBL volunteerBL = new volunteerBL();
        // GET: api/<VolunteersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VolunteersController>/5
        [Route("getById")]
        [HttpGet("{id}")]
        public DTO.volunteerDTO Get([FromBody] int id)
        {
            DTO.volunteerDTO value= volunteerBL.Getvolunteer("home");
            return value;
        }

        // POST api/<VolunteersController>
        [HttpPost]
        public void Post([FromBody] string name)//DTO.volunteerDTO value)
        {
            DTO.volunteerDTO value= new DTO.volunteerDTO();
            value.name = name;
            value.telephone = "12345";
            value.address = "home";
            volunteerBL.PostVolunteer(value);
        }

        // PUT api/<VolunteersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VolunteersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
