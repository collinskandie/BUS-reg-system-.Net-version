using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bus_REG_system.Data;
using Bus_REG_system.Models;

namespace Bus_REG_system.Controllers
{
    public class SaccoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SaccoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Saccoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sacco.ToListAsync());
        }

        // GET: Saccoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacco = await _context.Sacco
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sacco == null)
            {
                return NotFound();
            }

            return View(sacco);
        }

        // GET: Saccoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Saccoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SaccoID,SaccoName")] Sacco sacco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sacco);
        }

        // GET: Saccoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacco = await _context.Sacco.FindAsync(id);
            if (sacco == null)
            {
                return NotFound();
            }
            return View(sacco);
        }

        // POST: Saccoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SaccoID,SaccoName")] Sacco sacco)
        {
            if (id != sacco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaccoExists(sacco.Id))
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
            return View(sacco);
        }

        // GET: Saccoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacco = await _context.Sacco
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sacco == null)
            {
                return NotFound();
            }

            return View(sacco);
        }

        // POST: Saccoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacco = await _context.Sacco.FindAsync(id);
            _context.Sacco.Remove(sacco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaccoExists(int id)
        {
            return _context.Sacco.Any(e => e.Id == id);
        }
    }
}
