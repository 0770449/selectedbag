using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using selectedbag.Models;

    public class selectedbagContext : DbContext
    {
        public selectedbagContext (DbContextOptions<selectedbagContext> options)
            : base(options)
        {
        }

        public DbSet<selectedbag.Models.Bag> Bag { get; set; }
    }
