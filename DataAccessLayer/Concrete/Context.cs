using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {


        public DbSet<AccountLevel> AccountLevels { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Representative> Representatives { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<TicketForms> TicketForms { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Title> Titles { get; set; }
    }
}
