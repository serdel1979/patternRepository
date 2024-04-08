using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Model.Entities;

namespace Tasks.Model
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Worker> Workers { get; set; }


    }
}
