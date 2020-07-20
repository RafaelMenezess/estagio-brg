using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BRG.Models;

namespace brg.Models
{
    public class BRGContext : DbContext
    {
        public BRGContext (DbContextOptions<BRGContext> options)
            : base(options)
        {
        }

        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Habilidade> Habilidade { get; set; }
        public DbSet<Trilha> Trilha { get; set; }
    }
}
