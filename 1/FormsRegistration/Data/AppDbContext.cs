using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRegistration.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Change SQL SERVER NAME TO YOUR SERVER NAME AND UPDATE DATABASE
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-AELUB3Q\SQLEXPRESS;Database=registerDb;Trusted_Connection=True;");
            }
        }

    }
}
