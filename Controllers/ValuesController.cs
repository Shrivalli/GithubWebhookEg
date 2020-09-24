using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevopsParishaPrj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public List<string> ls = new List<string>();
        
        [Route("getnames")]
        [HttpGet]
        public List<string> getnames()
        {
            ls.Add("Ram");
            ls.Add("Radha");
            return ls;
        }
    }
}
