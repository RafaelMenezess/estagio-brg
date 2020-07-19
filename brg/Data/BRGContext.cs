using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BRG.Models;

namespace BRG.Data
{
    public class BRGContext : DbContext
    {
        public BRGContext (DbContextOptions<BRGContext> options)
            : base(options)
        {
        }

        public DbSet<BRG.Models.Colaborador> Colaborador { get; set; }
    }
}
