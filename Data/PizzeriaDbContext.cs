﻿using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Data
{
    public class PizzeriaDbContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizzeria;Integrated Security=True;Encrypt=false;");
        }
    }
}
