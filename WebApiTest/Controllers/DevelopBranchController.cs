using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopBranchController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "DevelopBranch1", "DevelopBranch2" };
        }

        // GET: api/DevelopBranch/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "DevelopBranch1";
        }



        // GET: api/DevelopBranch/5
        [HttpPost]
        public string Post(int id)
        {
            return "DevelopBranch1";
        }

    }
}

