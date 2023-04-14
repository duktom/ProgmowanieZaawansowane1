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
    public class SmartphonesController : Controller
    {
        private readonly MvcSmartphoneContext _context;

        public SmartphonesController(MvcSmartphoneContext context)
        {
            _context = context;
        }

        // GET: Smartphones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Smartphone.ToListAsync());
        }

        // GET: Smartphones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smartphone = await _context.Smartphone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smartphone == null)
            {
                return NotFound();
            }

            return View(smartphone);
        }

        // GET: Smartphones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Smartphones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rom,CoreNr,DisplaySize,Weight,Battery")] Smartphone smartphone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smartphone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(smartphone);
        }

        // GET: Smartphones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smartphone = await _context.Smartphone.FindAsync(id);
            if (smartphone == null)
            {
                return NotFound();
            }
            return View(smartphone);
        }

        // POST: Smartphones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rom,CoreNr,DisplaySize,Weight,Battery")] Smartphone smartphone)
        {
            if (id != smartphone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smartphone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmartphoneExists(smartphone.Id))
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
            return View(smartphone);
        }

        // GET: Smartphones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smartphone = await _context.Smartphone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smartphone == null)
            {
                return NotFound();
            }

            return View(smartphone);
        }

        // POST: Smartphones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var smartphone = await _context.Smartphone.FindAsync(id);
            _context.Smartphone.Remove(smartphone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmartphoneExists(int id)
        {
            return _context.Smartphone.Any(e => e.Id == id);
        }
    }
}
