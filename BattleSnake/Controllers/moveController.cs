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
    public class moveController : ControllerBase
    {
        // POST: /move
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Snake state = Snake.Instance;

        }
    }
}
