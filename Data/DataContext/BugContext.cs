using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Data.DataContext
{
    public class BugContext : DbContext
    {
        public BugContext(DbContextOptions<BugContext> options) : base(options)
        {
        }

        public DbSet<Bugs> Project_Bugs { get; set; }
    }
}
