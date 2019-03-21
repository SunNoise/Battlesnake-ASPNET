using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BattleSnake.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class pingController : ControllerBase
    {
        // POST: /ping
        [HttpPost]
        public string Post()
        {
            return "alive";
        }
    }
}
