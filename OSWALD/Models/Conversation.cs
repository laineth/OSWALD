using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OSWALD.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public string UserInput { get; set; }
        public string BotAnswer { get; set; }
    }
}