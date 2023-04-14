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
    public class PotsController : Controller
    {
        private readonly MvcPotContext _context;

        public PotsController(MvcPotContext context)
        {
            _context = context;
        }

        // GET: Pots
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pot.ToListAsync());
        }

        // GET: Pots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pot = await _context.Pot
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pot == null)
            {
                return NotFound();
            }

            return View(pot);
        }

        // GET: Pots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Volume,Weight,LidType,Handles,Material")] Pot pot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pot);
        }

        // GET: Pots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pot = await _context.Pot.FindAsync(id);
            if (pot == null)
            {
                return NotFound();
            }
            return View(pot);
        }

        // POST: Pots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Volume,Weight,LidType,Handles,Material")] Pot pot)
        {
            if (id != pot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PotExists(pot.Id))
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
            return View(pot);
        }

        // GET: Pots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pot = await _context.Pot
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pot == null)
            {
                return NotFound();
            }

            return View(pot);
        }

        // POST: Pots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pot = await _context.Pot.FindAsync(id);
            _context.Pot.Remove(pot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PotExists(int id)
        {
            return _context.Pot.Any(e => e.Id == id);
        }
    }
}
