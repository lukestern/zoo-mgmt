﻿using Microsoft.EntityFrameworkCore;
using Zoo.DbModels;

namespace Zoo
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options) {}
        
        public DbSet<AnimalDbModel> Animal { get; set; }
    }
}