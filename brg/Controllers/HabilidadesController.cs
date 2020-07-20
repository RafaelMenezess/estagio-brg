using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using brg.Models;

namespace brg.Controllers
{
    public class HabilidadesController : Controller
    {
        private readonly BRGContext _context;

        public HabilidadesController(BRGContext context)
        {
            _context = context;
        }

        // GET: Habilidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Habilidade.ToListAsync());
        }

        // GET: Habilidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habilidade = await _context.Habilidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habilidade == null)
            {
                return NotFound();
            }

            return View(habilidade);
        }

        // GET: Habilidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Habilidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,Nome")] Habilidade habilidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habilidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(habilidade);
        }

        // GET: Habilidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habilidade = await _context.Habilidade.FindAsync(id);
            if (habilidade == null)
            {
                return NotFound();
            }
            return View(habilidade);
        }

        // POST: Habilidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,Nome")] Habilidade habilidade)
        {
            if (id != habilidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habilidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabilidadeExists(habilidade.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(habilidade);
        }

        // GET: Habilidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habilidade = await _context.Habilidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habilidade == null)
            {
                return NotFound();
            }

            return View(habilidade);
        }

        // POST: Habilidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var habilidade = await _context.Habilidade.FindAsync(id);
            _context.Habilidade.Remove(habilidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HabilidadeExists(int id)
        {
            return _context.Habilidade.Any(e => e.Id == id);
        }
    }
}
