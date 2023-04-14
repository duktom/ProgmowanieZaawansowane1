using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson1.Data;
using AdvancedProgramming_Lesson1.Models;

namespace AdvancedProgramming_Lesson1.Controllers
{
    public class AlcocholsController : Controller
    {
        private readonly MvcAlcocholContext _context;

        public AlcocholsController(MvcAlcocholContext context)
        {
            _context = context;
        }

        // GET: Alcochols
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alcochol.ToListAsync());
        }

        // GET: Alcochols/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcochol = await _context.Alcochol
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alcochol == null)
            {
                return NotFound();
            }

            return View(alcochol);
        }

        // GET: Alcochols/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alcochols/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Volume,AlcVolume,SugarVolume,Price,ProductonDate")] Alcochol alcochol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alcochol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alcochol);
        }

        // GET: Alcochols/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcochol = await _context.Alcochol.FindAsync(id);
            if (alcochol == null)
            {
                return NotFound();
            }
            return View(alcochol);
        }

        // POST: Alcochols/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Volume,AlcVolume,SugarVolume,Price,ProductonDate")] Alcochol alcochol)
        {
            if (id != alcochol.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alcochol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlcocholExists(alcochol.Id))
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
            return View(alcochol);
        }

        // GET: Alcochols/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcochol = await _context.Alcochol
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alcochol == null)
            {
                return NotFound();
            }

            return View(alcochol);
        }

        // POST: Alcochols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alcochol = await _context.Alcochol.FindAsync(id);
            _context.Alcochol.Remove(alcochol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlcocholExists(int id)
        {
            return _context.Alcochol.Any(e => e.Id == id);
        }
    }
}
