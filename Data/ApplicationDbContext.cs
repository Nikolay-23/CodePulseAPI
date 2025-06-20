﻿using CodePulseAPI.Data.Extensions;
using CodePulseAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace CodePulseAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
           
        }
    }
}
