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
        public DateTime ConversationDate { get; set; }
    }
}