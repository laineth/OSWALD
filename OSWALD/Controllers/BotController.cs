using OSWALD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using System.Web;

namespace OSWALD.Controllers
{
    public class BotController : ApiController
    {
        // use data.value in order create an appropriate response
        [HttpPost]
        public void Post([FromBody] dynamic data)
        {
            
        }
    }
}
