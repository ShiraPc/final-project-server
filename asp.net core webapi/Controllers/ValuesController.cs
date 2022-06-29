
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
namespace asp.net_core_webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public ValuesController()
        {

        }
        
        [HttpPost]
        public string Get()
        {


            //var c = collection.Find<string,string>(q=>  q.firstName="abc").select();
            return "get";
        }
        
        [HttpGet]
        //[Route("[GetBusiness]")]
        public volunteerDTO GetBusiness()
        {

            return new volunteerDTO();
        }
        
    }
}
