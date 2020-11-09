using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app02.Data;
using app02.Models.Entidades;
using app02.Services;

namespace app02.Controllers
{
    public class TitulosController : Controller
    {
        private readonly app02Context _context;
        private readonly ClienteService _clienteService;

        public TitulosController(app02Context context, ClienteService clienteService)
        {
            _context = context;
            _clienteService = clienteService;
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

            var titulo = await _context.Titulos.Include(c => c.Cliente).FirstOrDefaultAsync(x => x.Id == id);

            if (titulo == null || titulo.Id != id)
            {
                return NotFound("Titulo Não Encontrado");
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
        public async Task<IActionResult> Create(Titulo titulo)
        {

            titulo.Status = 1;
            _context.Titulos.Add(titulo);

            await _clienteService.AddTitulosAsync(titulo.ClienteId, titulo);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Titulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound("Titulo Não Encontrado");
            }

            var titulo = await _context.Titulos.FindAsync(id);


            if (titulo == null || titulo.Id != id)
            {
                return NotFound("Titulo Não Encontrado");
            }

            return View(titulo);

        }
        // POST: Titulos/Edit
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,Documento,ClienteId,Emissao,Vencimento,Valor,Status")] Titulo titulo)
        {

            if (!ModelState.IsValid)
            {
                return NotFound("Model State Invalido");
            }

            try
            {
                _context.Titulos.Update(titulo);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                return NotFound(e.Message);
            }

            return RedirectToAction(nameof(Index));
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
            if (titulo == null || titulo.Id != id)
            {
                return NotFound("Titulo Não Encontrado");
            }

            return View(titulo);
        }

        // POST: Titulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var titulo = await _context.Titulos.FindAsync(id);

            if (titulo == null || titulo.Id != id)
            {
                return NotFound("Titulo Não Encontrado");
            }

            _context.Titulos.Remove(titulo);

            await _clienteService.RemTitulosAsync(titulo.ClienteId, titulo);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool TituloExists(int id)
        {
            return _context.Titulos.Any(x => x.Id == id);
        }

        // Busca com filtro de Datas de Vencimento
        public async Task<IActionResult> FindbyDate(DateTime? dataini, DateTime? datafim, Cliente cliente)

        {
            if (!dataini.HasValue)
            {
                dataini = new DateTime(DateTime.Now.Year, 01, 01);
            }

            if (!datafim.HasValue)
            {
                datafim = new DateTime(DateTime.Now.Year, 12, 31);
            }


            var listadetitulos = _context.Titulos.Include(t => t.Cliente);
            var selecao = listadetitulos.Where(x => x.Vencimento >= dataini & x.Vencimento <= datafim);

            ViewData["dataini"] = dataini.Value.ToString("ddMMyyyy");
            ViewData["datafim"] = datafim.Value.ToString("ddMMyyyy");


            return View(await selecao.ToListAsync());
        }


        // GET: Titulos/Pagamento
        public async Task<IActionResult> Payment(int? id)
        {
            if (id == null)
            {
                return NotFound("Numero do Título Nulo no Metodo Get");
            }

            var titulo = await _context.Titulos
              .Include(t => t.Cliente)
              .FirstOrDefaultAsync(m => m.Id == id);

            if (titulo == null)
            {
                return NotFound("Titulo Não Encontrado no Metodo Get");
            }
            if (id != titulo.Id)
            {
                return NotFound("Titulo Encontrado Diferente do Procurado no Metodo GET");
            }

            return View(titulo);
        }

        // POST: Titulos/Pagamento
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Payment")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Payment(int id, [Bind("Id,Documento,Valor,Emissao,Vencimento,ClienteId,Pagamento,Status")]
                                                 Titulo titulo)
        {
            if (id != titulo.Id)
            {
                return NotFound("Titulo Não Encontrado");
            }

            if (!ModelState.IsValid)
            {
                return NotFound("Model State Invalido");
            }

            try
            {
                var tituloatualizado =  CalculaPagamento(titulo);
                _context.Titulos.Update(tituloatualizado);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!TituloExists(titulo.Id))
                {
                    return NotFound("Título não Existe");
                }
                else
                {
                    return NotFound(e.Message);
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public Titulo CalculaPagamento(Titulo titulo)
        {
            if (titulo.Pagamento > titulo.Vencimento)
            {
                var atraso = titulo.Pagamento.Subtract(titulo.Vencimento).TotalDays;
                titulo.Juros = titulo.Valor * 0.01 / 30 * atraso;
                titulo.Multa = titulo.Valor * 0.02;
            }
            titulo.Totalpago = titulo.Valor + titulo.Juros + titulo.Multa;
            titulo.Status = 2;
            return titulo;
        }
    }
}
