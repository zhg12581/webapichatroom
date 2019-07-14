using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using webapichatroom.Models;

namespace webapichatroom.DAL
{
    public class AccountContext : DbContext
    {
        public AccountContext()
            : base("AccountContext")
        {

        }
        public DbSet<AllUser> AllUsers { get; set; }
        public DbSet<ChatMessages> ChatMessagess { get; set; }

        public DbSet<GroupInformation> GroupInformations { get; set; }
        public DbSet<GroupMembers> GroupMemberss { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}