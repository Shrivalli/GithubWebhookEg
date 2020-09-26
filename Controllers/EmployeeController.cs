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
    ///<summary>
    ///Employee Controller Added
    ///</summary>
    public class EmployeeController : ControllerBase
    {
        //Empcontroller modified
        public string add()
        {
            return "add";
        }
    }
}
