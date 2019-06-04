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
    public class ArtikliController : Controller
    {
        private readonly BestDealContext _context;
        public ArtikliController(BestDealContext context)
        {
            _context = context;
        }

        // GET: Artikli
        public async Task<IActionResult> Index()
        {
           // ViewBag.tipovi = _context.Tip.ToList();
            return View(await _context.Artikal.ToListAsync());
        }
        public JsonResult dajTip(string ime)
        {
            List<Tip> lista = new List<Tip>();
            lista = _context.Tip.Where(a => a.Ime == ime).ToList();
            lista.Insert(0, new Tip("Odaberite tip artikla"));
            return Json(new SelectList(lista, "Ime"));
        }
        // GET: Artikli/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikal = await _context.Artikal
                .FirstOrDefaultAsync(m => m.IdArtikla == id);
            if (artikal == null)
            {
                return NotFound();
            }

            return View(artikal);
        }

        // GET: Artikli/Create
        public IActionResult Create()
        {
            ViewBag.tipovi = _context.Tip.ToList();
            return View();
        }

        // POST: Artikli/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CijenaArtikla,IdArtikla")] Artikal artikal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artikal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artikal);
        }

        // GET: Artikli/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikal = await _context.Artikal.FindAsync(id);
            if (artikal == null)
            {
                return NotFound();
            }
            return View(artikal);
        }

        // POST: Artikli/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CijenaArtikla,IdArtikla")] Artikal artikal)
        {
            if (id != artikal.IdArtikla)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artikal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtikalExists(artikal.IdArtikla))
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
            return View(artikal);
        }

        // GET: Artikli/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikal = await _context.Artikal
                .FirstOrDefaultAsync(m => m.IdArtikla == id);
            if (artikal == null)
            {
                return NotFound();
            }

            return View(artikal);
        }

        // POST: Artikli/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artikal = await _context.Artikal.FindAsync(id);
            _context.Artikal.Remove(artikal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtikalExists(int id)
        {
            return _context.Artikal.Any(e => e.IdArtikla == id);
        }
    }
}
