using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestDeal.Models;

namespace BestDeal.Controllers
{
    public class TipController : Controller
    {
        private readonly BestDealContext _context;

        public TipController(BestDealContext context)
        {
            _context = context;
        }

        // GET: Tip
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tip.ToListAsync());
        }

        // GET: Tip/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tip = await _context.Tip
                .FirstOrDefaultAsync(m => m.idTipa == id);
            if (tip == null)
            {
                return NotFound();
            }

            return View(tip);
        }

        // GET: Tip/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tip/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTipa,Ime")] Tip tip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tip);
        }

        // GET: Tip/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tip = await _context.Tip.FindAsync(id);
            if (tip == null)
            {
                return NotFound();
            }
            return View(tip);
        }

        // POST: Tip/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTipa,Ime")] Tip tip)
        {
            if (id != tip.idTipa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipExists(tip.idTipa))
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
            return View(tip);
        }

        // GET: Tip/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tip = await _context.Tip
                .FirstOrDefaultAsync(m => m.idTipa == id);
            if (tip == null)
            {
                return NotFound();
            }

            return View(tip);
        }

        // POST: Tip/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tip = await _context.Tip.FindAsync(id);
            _context.Tip.Remove(tip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipExists(int id)
        {
            return _context.Tip.Any(e => e.idTipa == id);
        }
    }
}
