using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P01_Chushka.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Chushka.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-AELUB3Q\SQLEXPRESS;Database=ChushkaDb;Integrated Security=True;");
            }
        }
    }
}
