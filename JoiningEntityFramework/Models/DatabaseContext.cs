using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JoiningEntityFramework.Models
{
    public class DatabaseContext :DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Room> Room { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}