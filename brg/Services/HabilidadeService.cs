using brg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brg.Services
{
    public class HabilidadeService
    {
        private readonly BRGContext _context;

        public HabilidadeService(BRGContext context)
        {
            _context = context;
        }
        public List<Habilidade> FindAll()
        {
            return _context.Habilidade.OrderBy(x => x.Id).ToList();
        }
    }
}
