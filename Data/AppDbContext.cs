﻿using CrudApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
