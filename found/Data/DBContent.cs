using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using found.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace found.Data
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DbSet<Advert> adv { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Dialogs> dialogs { get; set; }
        public DbSet<Messages> messages { get; set; }
    }
}
