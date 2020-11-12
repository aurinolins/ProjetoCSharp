using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app02.Data;
using app02.Models.Entidades;

namespace app02.Controllers
{
    public class IndicesController : Controller
    {
        private readonly app02Context _context;

        public IndicesController(app02Context context)
        {
            _context = context;
        }

        // GET: Indices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Indices.ToListAsync());
        }

        // GET: Indices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indices = await _context.Indices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indices == null)
            {
                return NotFound();
            }

            return View(indices);
        }

        // GET: Indices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Indices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Periodo,Juros,Multa")] Indices indices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indices);
        }

        // GET: Indices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indices = await _context.Indices.FindAsync(id);
            if (indices == null)
            {
                return NotFound();
            }
            return View(indices);
        }

        // POST: Indices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Periodo,Juros,Multa")] Indices indices)
        {
            if (id != indices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndicesExists(indices.Id))
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
            return View(indices);
        }

        // GET: Indices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indices = await _context.Indices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indices == null)
            {
                return NotFound();
            }

            return View(indices);
        }

        // POST: Indices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indices = await _context.Indices.FindAsync(id);
            _context.Indices.Remove(indices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndicesExists(int id)
        {
            return _context.Indices.Any(e => e.Id == id);
        }
    }
}
