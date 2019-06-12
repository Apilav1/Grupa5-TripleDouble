using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestDeal.Models;
using System.Diagnostics;

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
            return View(await _context.Artikal.ToListAsync());
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
        public IActionResult AddOrEdit(int id=111)
        {
            return View(new Artikal());
        }

        // POST: Artikli/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CijenaArtikla,NazivArtikla,KratkiOpis,DetaljniOpis,URLSlike1,URLMaleSlike1, tipNaziv")] Artikal artikal)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
              
                    _context.Add(artikal);
                    _context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT dbo.Artikal ON");
                    _context.SaveChanges();
                    _context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT dbo.Artikal OFF");

                    transaction.Commit();
                }
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
               
                var errors = ModelState.Select(x => x.Value.Errors)
                           .Where(y => y.Count > 0)
                           .ToList();

                Debug.WriteLine("not valid");
                foreach (object o in errors)
                    Debug.WriteLine(o.ToString());
                Debug.WriteLine("not valid");
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
        public async Task<IActionResult> Edit(int id, [Bind("CijenaArtikla,IdArtikla,NazivArtikla,KratkiOpis,DetaljniOpis,URLSlike1,URLMaleSlike1")] Artikal artikal)
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
