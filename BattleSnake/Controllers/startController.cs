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
    public class startController : ControllerBase
    {
        // POST: /start
        [HttpPost]
        public string Post([FromBody] string value)
        {
            //TODO: Change return type to a json object
            Snake state = Snake.Instance;
            if (state.InUse())
                return "ERROR: Already in play.";
            state.Initialize();
            return "json string";
        }
    }
}
