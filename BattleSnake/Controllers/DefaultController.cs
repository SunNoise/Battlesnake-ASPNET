using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BattleSnake.Controllers
{
    [Route("")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        // GET: /
        [HttpGet]
        public ContentResult Get()
        {
            var response =  "<html><title>Battlesnake AI </title><body>Battlesnake documentation can be found at " +
                "<a href=\"https://docs.battlesnake.io\">https://docs.battlesnake.io</a>.</body></html>";
            return Content(response, "text/html", Encoding.UTF8); ;
        }
    }
}
