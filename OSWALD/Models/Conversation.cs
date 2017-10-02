using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSWALD.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public DateTime ConversationDate { get; set; }
        public string User { get; set; }
        public string Bot { get; set; } 
    }
}