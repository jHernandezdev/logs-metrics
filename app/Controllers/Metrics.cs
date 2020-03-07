using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsController : ControllerBase
    {        
        [HttpGet]
        public string Get()
        {            
            int i = new Random().Next(1, 10000);
            return $"ventas_promedia {i}";            
        }
    }
}
