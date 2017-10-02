using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OSWALD.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OSWALD.DAL
{
    public class ConversationContext : DbContext
    {
        public ConversationContext() : base("ConversationContext")
        {
        }

        public DbSet<Conversation> Conversations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}