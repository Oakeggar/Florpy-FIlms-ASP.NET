﻿using Microsoft.EntityFrameworkCore;

namespace FlorpyFIlms.Models.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
