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
    public class TrilhasController : Controller
    {
        private readonly BRGContext _context;

        public TrilhasController(BRGContext context)
        {
            _context = context;
        }

        // GET: Trilhas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trilha.ToListAsync());
        }

        // GET: Trilhas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trilha = await _context.Trilha
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trilha == null)
            {
                return NotFound();
            }

            return View(trilha);
        }

        // GET: Trilhas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trilhas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Prazo")] Trilha trilha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trilha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trilha);
        }

        // GET: Trilhas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trilha = await _context.Trilha.FindAsync(id);
            if (trilha == null)
            {
                return NotFound();
            }
            return View(trilha);
        }

        // POST: Trilhas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Prazo")] Trilha trilha)
        {
            if (id != trilha.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trilha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrilhaExists(trilha.Id))
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
            return View(trilha);
        }

        // GET: Trilhas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trilha = await _context.Trilha
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trilha == null)
            {
                return NotFound();
            }

            return View(trilha);
        }

        // POST: Trilhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trilha = await _context.Trilha.FindAsync(id);
            _context.Trilha.Remove(trilha);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrilhaExists(int id)
        {
            return _context.Trilha.Any(e => e.Id == id);
        }
    }
}
