using brg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brg.Data
{
    public class SeedingService
    {
        private BRGContext _context;

        public SeedingService(BRGContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Colaborador.Any()||
                _context.Habilidade.Any()||
                _context.Trilha.Any())
            {
                return;
            }

        }
    }
}
