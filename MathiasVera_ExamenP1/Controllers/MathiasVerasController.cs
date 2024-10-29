using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MathiasVera_ExamenP1.Data;
using MathiasVera_ExamenP1.Models;

namespace MathiasVera_ExamenP1.Controllers
{
    public class MathiasVerasController : Controller
    {
        private readonly MathiasVera_ExamenP1Context _context;

        public MathiasVerasController(MathiasVera_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: MathiasVeras
        public async Task<IActionResult> Index()
        {
            return View(await _context.MathiasVera.ToListAsync());
        }

        // GET: MathiasVeras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathiasVera = await _context.MathiasVera
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mathiasVera == null)
            {
                return NotFound();
            }

            return View(mathiasVera);
        }

        // GET: MathiasVeras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MathiasVeras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Promedio,Correo,TieneBeca,FechaNacimiento")] MathiasVera mathiasVera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mathiasVera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mathiasVera);
        }

        // GET: MathiasVeras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathiasVera = await _context.MathiasVera.FindAsync(id);
            if (mathiasVera == null)
            {
                return NotFound();
            }
            return View(mathiasVera);
        }

        // POST: MathiasVeras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Promedio,Correo,TieneBeca,FechaNacimiento")] MathiasVera mathiasVera)
        {
            if (id != mathiasVera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mathiasVera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MathiasVeraExists(mathiasVera.Id))
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
            return View(mathiasVera);
        }

        // GET: MathiasVeras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathiasVera = await _context.MathiasVera
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mathiasVera == null)
            {
                return NotFound();
            }

            return View(mathiasVera);
        }

        // POST: MathiasVeras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mathiasVera = await _context.MathiasVera.FindAsync(id);
            if (mathiasVera != null)
            {
                _context.MathiasVera.Remove(mathiasVera);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MathiasVeraExists(int id)
        {
            return _context.MathiasVera.Any(e => e.Id == id);
        }
    }
}
