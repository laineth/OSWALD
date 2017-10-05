using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OSWALD.Models;

namespace OSWALD.DAL
{
    public class ConversationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ConversationContext>
    {
        protected override void Seed(ConversationContext context)
        {
            var conversations = new List<Conversation>
            {
                new Conversation { Id = 1, UserInput = "" }
            };

            conversations.ForEach(c => context.Conversations.Add(c));
            context.SaveChanges();
        }
    }
}