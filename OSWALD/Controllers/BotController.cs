using OSWALD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using System.Web;
using OSWALD.DAL;

namespace OSWALD.Controllers
{
    // Receive a JSON Object
    // IF id = 0: SELECT ID in the DB in order to check the number of already existing IDs then INSERT INTO new ID in the DB
    // This will define a new conversation with the chatbot

    public class BotController : ApiController
    {
        // use data.value in order create an appropriate response
        [HttpPost]
        public void CreateConversation([FromBody] Conversation data)
        {
            using (var req = new ConversationContext())
            {
                req.Database.ExecuteSqlCommand("INSERT INTO Conversation (UserInput) VALUES ('" + data.UserInput + "')");
                //req.Database.ExecuteSqlCommand("TRUNCATE TABLE Conversation;");
            } 
        }

        [Route("bot/id")]
        [HttpPost]
        public void ContinueConversation([FromBody] Conversation data)
        {

        }
    }
}
