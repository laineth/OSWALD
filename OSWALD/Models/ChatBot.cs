using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSWALD.Models
{
    public class Chatbot
    {
        [Display(Name = "Name")]
        public string BotName { get; set; }
    }
}