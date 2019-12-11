﻿using AspNetCore22Intro.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore22Intro.Data
{
    public class VideoDbContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }

        public VideoDbContext(DbContextOptions<VideoDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
