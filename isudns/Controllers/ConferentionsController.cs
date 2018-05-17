using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using isudns.Data;
using isudns.Models;
using Microsoft.AspNetCore.Authorization;

namespace isudns.Controllers
{
    [Authorize(Roles = "admin")]
    public class ConferentionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConferentionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        // GET: Conferentions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Conferentions.ToListAsync());
        }

        [AllowAnonymous]
        // GET: Conferentions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conferention = await _context.Conferentions
                .SingleOrDefaultAsync(m => m.Id == id);
            if (conferention == null)
            {
                return NotFound();
            }

            return View(conferention);
        }

        // GET: Conferentions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conferentions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Date,Location")] Conferention conferention)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conferention);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conferention);
        }

        // GET: Conferentions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conferention = await _context.Conferentions.SingleOrDefaultAsync(m => m.Id == id);
            if (conferention == null)
            {
                return NotFound();
            }
            return View(conferention);
        }

        // POST: Conferentions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Date,Location")] Conferention conferention)
        {
            if (id != conferention.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conferention);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConferentionExists(conferention.Id))
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
            return View(conferention);
        }

        // GET: Conferentions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conferention = await _context.Conferentions
                .SingleOrDefaultAsync(m => m.Id == id);
            if (conferention == null)
            {
                return NotFound();
            }

            return View(conferention);
        }

        // POST: Conferentions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conferention = await _context.Conferentions.SingleOrDefaultAsync(m => m.Id == id);
            _context.Conferentions.Remove(conferention);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConferentionExists(int id)
        {
            return _context.Conferentions.Any(e => e.Id == id);
        }
    }
}
