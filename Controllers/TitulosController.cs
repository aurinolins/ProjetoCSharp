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
    public class TitulosController : Controller
    {
        private readonly app02Context _context;

        public TitulosController(app02Context context)
        {
            _context = context;
        }

        // GET: Titulos
        public async Task<IActionResult> Index()
        
        {
            var app02Context = _context.Titulos.Include(t => t.Cliente);

            return View(await app02Context.ToListAsync());
        }

        // GET: Titulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titulo = await _context.Titulos
                .Include(t => t.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (titulo == null)
            {
                return NotFound();
            }

            return View(titulo);
        }

        // GET: Titulos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id");
            return View();
        }

        // POST: Titulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Documento,Valor,Emissao,Vencimento,ClienteId,Status")] Titulo titulo)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            _context.Add(titulo);
            await _context.SaveChangesAsync();

            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", titulo.ClienteId);
            return View(titulo);
        }

        // GET: Titulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titulo = await _context.Titulos.FindAsync(id);
            if (titulo == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", titulo.ClienteId);
            return View(titulo);
        }

        // POST: Titulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Documento,Valor,Emissao,Vencimento,ClienteId,Status")] Titulo titulo)
        {
            if (id != titulo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(titulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TituloExists(titulo.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", titulo.ClienteId);
            return View(titulo);
        }

        // GET: Titulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titulo = await _context.Titulos
                .Include(t => t.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (titulo == null)
            {
                return NotFound();
            }

            return View(titulo);
        }

        // POST: Titulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var titulo = await _context.Titulos.FindAsync(id);
            _context.Titulos.Remove(titulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TituloExists(int id)
        {
            return _context.Titulos.Any(e => e.Id == id);
        }

        // Busca com filtro de Datas de Vencimento
        public async Task<IActionResult> FindbyDate(DateTime? dataini,DateTime? datafim, Cliente cliente)

        {
            if (!dataini.HasValue)
            {
                dataini = new DateTime(DateTime.Now.Year, 01, 01);
            }

            if (!datafim.HasValue)
            {
                dataini = new DateTime(DateTime.Now.Year, 12, 31);
            }


            var listadetitulos = _context.Titulos.Include(t => t.Cliente);
            var selecao = listadetitulos.Where(x => x.Vencimento >= dataini & x.Vencimento <= datafim);

            ViewData["dataini"] = dataini.Value.ToString("ddMMyyyy");
            ViewData["datafim"] = datafim.Value.ToString("ddMMyyyy");


            return View(await selecao.ToListAsync());
        }

    }
}
