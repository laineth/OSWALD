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
    // Receive a JSON Object
    // IF id = 0: SELECT ID in the DB in order to check the number of already existing IDs then INSERT INTO new ID in the DB
    // This will define a new conversation with the chatbot

    public class BotController : ApiController
    {
        
        // use data.value in order create an appropriate response
        [HttpPost]
        public void Post([FromBody] Conversation data)
        {
            
        }
    }
}
