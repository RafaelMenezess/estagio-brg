using brg.Models;
using BRG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brg.Services
{
    public class ColaboradorService
    {  

            private readonly BRGContext _context;

            public ColaboradorService(BRGContext context)
            {
                _context = context;
            }
            public List<Colaborador> FindAll()
            {
                return _context.Colaborador.OrderBy(x => x.Id).ToList();
            }
        
    }

}

