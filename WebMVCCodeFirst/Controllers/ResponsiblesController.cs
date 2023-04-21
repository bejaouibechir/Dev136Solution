using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVCCodeFirst.Models;

namespace WebMVCCodeFirst.Controllers
{
    public class ResponsiblesController : Controller
    {
        private readonly StoreContext _context;

        public ResponsiblesController(StoreContext context)
        {
            _context = context;
        }

        // GET: Responsibles
        public async Task<IActionResult> Index()
        {
              return View(await _context.Responsible.ToListAsync());
        }

        // GET: Responsibles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Responsible == null)
            {
                return NotFound();
            }

            var responsible = await _context.Responsible
                .FirstOrDefaultAsync(m => m.Id == id);
            if (responsible == null)
            {
                return NotFound();
            }

            return View(responsible);
        }

        // GET: Responsibles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Responsibles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Experience")] Responsible responsible)
        {
            if (ModelState.IsValid)
            {
                _context.Add(responsible);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(responsible);
        }

        // GET: Responsibles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Responsible == null)
            {
                return NotFound();
            }

            var responsible = await _context.Responsible.FindAsync(id);
            if (responsible == null)
            {
                return NotFound();
            }
            return View(responsible);
        }

        // POST: Responsibles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Experience")] Responsible responsible)
        {
            if (id != responsible.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(responsible);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResponsibleExists(responsible.Id))
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
            return View(responsible);
        }

        // GET: Responsibles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Responsible == null)
            {
                return NotFound();
            }

            var responsible = await _context.Responsible
                .FirstOrDefaultAsync(m => m.Id == id);
            if (responsible == null)
            {
                return NotFound();
            }

            return View(responsible);
        }

        // POST: Responsibles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Responsible == null)
            {
                return Problem("Entity set 'StoreContext.Responsible'  is null.");
            }
            var responsible = await _context.Responsible.FindAsync(id);
            if (responsible != null)
            {
                _context.Responsible.Remove(responsible);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResponsibleExists(int id)
        {
          return _context.Responsible.Any(e => e.Id == id);
        }
    }
}
