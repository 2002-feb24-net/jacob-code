using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Library.Models;
using RestaurantReviews.Library.Repositories;

namespace RestaurantReviews.ConsoleApp
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=../../../restaurants.db";
            // need another package for this (Microsoft.EntityFrameworkCore.Sqlite)
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
