using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SoGest.Data.Model.Entities;
using SoGest.Data.Repositories.Context;

namespace SoGest.UI.Views.Clientes
{
    public class AlmacensController : Controller
    {
        private readonly SoGestDBContext _context;

        public AlmacensController ( SoGestDBContext context )
        {
            _context = context;
        }

        // GET: Almacens
        public async Task<IActionResult> Index ()
        {
            return View(await _context.Almacenes.ToListAsync( ));
        }

        // GET: Almacens/Details/5
        public async Task<IActionResult> Details ( int? id )
        {
            if ( id == null )
            {
                return NotFound( );
            }

            var almacen = await _context.Almacenes
                .FirstOrDefaultAsync(m => m.Id == id);
            if ( almacen == null )
            {
                return NotFound( );
            }

            return View(almacen);
        }

        // GET: Almacens/Create
        public IActionResult Create ()
        {
            return View( );
        }

        // POST: Almacens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ( [Bind("Id,Descripcion,Activo")] Almacen almacen )
        {
            if ( ModelState.IsValid )
            {
                _context.Add(almacen);
                await _context.SaveChangesAsync( );
                return RedirectToAction(nameof(Index));
            }
            return View(almacen);
        }

        // GET: Almacens/Edit/5
        public async Task<IActionResult> Edit ( int? id )
        {
            if ( id == null )
            {
                return NotFound( );
            }

            var almacen = await _context.Almacenes.FindAsync(id);
            if ( almacen == null )
            {
                return NotFound( );
            }
            return View(almacen);
        }

        // POST: Almacens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit ( int id, [Bind("Id,Descripcion,Activo")] Almacen almacen )
        {
            if ( id != almacen.Id )
            {
                return NotFound( );
            }

            if ( ModelState.IsValid )
            {
                try
                {
                    _context.Update(almacen);
                    await _context.SaveChangesAsync( );
                }
                catch ( DbUpdateConcurrencyException )
                {
                    if ( !AlmacenExists(almacen.Id) )
                    {
                        return NotFound( );
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(almacen);
        }

        // GET: Almacens/Delete/5
        public async Task<IActionResult> Delete ( int? id )
        {
            if ( id == null )
            {
                return NotFound( );
            }

            var almacen = await _context.Almacenes
                .FirstOrDefaultAsync(m => m.Id == id);
            if ( almacen == null )
            {
                return NotFound( );
            }

            return View(almacen);
        }

        // POST: Almacens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed ( int id )
        {
            var almacen = await _context.Almacenes.FindAsync(id);
            _context.Almacenes.Remove(almacen);
            await _context.SaveChangesAsync( );
            return RedirectToAction(nameof(Index));
        }

        private bool AlmacenExists ( int id )
        {
            return _context.Almacenes.Any(e => e.Id == id);
        }
    }
}
