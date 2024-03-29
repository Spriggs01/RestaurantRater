﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

    }

    public class RestaurantDBContext : DbContext
    {
        //sets a table , Restaurant, DbSet = Database Set 
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}