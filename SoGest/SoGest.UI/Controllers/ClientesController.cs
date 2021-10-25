﻿using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

namespace SoGest.UI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesController ( IClienteRepository clienteRepository )
        {
            _clienteRepository = clienteRepository;
        }

        // GET: Clientes
        public async Task<IActionResult> Index ()
        {
            return View(await _clienteRepository.GetAsync( ));
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details ( int? id )
        {
            if ( id == null )
            {
                return NotFound( );
            }

            var cliente = await _clienteRepository.GetClienteByIdAsync(( int ) id);

            if ( cliente == null )
            {
                return NotFound( );
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create ()
        {
            return View( );
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ( [Bind("Id,Nombre,Apellidos,TipoDocumentoId,RazonSocial,Direccion,CodPostal,Poblacion,Provincia,NombreContacto,ApellidoContacto,Fijo,Movil,Correo,Foto,Notas,Aniversario,Activo,Documento")] Cliente cliente )
        {
            if ( ModelState.IsValid )
            {
                _clienteRepository.Add(cliente);
                //TODO: Cambiar a Unit of Work
                await _clienteRepository.GuardarCambiosAsync( );
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit ( int? id )
        {
            if ( id == null )
            {
                return NotFound( );
            }

            var cliente = await _clienteRepository.GetClienteByIdAsync(( int ) id);
            if ( cliente == null )
            {
                return NotFound( );
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit ( int id, [Bind("Id,Nombre,Apellidos,TipoDocumentoId,RazonSocial,Direccion,CodPostal,Poblacion,Provincia,NombreContacto,ApellidoContacto,Fijo,Movil,Correo,Foto,Notas,Aniversario,Activo,Documento")] Cliente cliente )
        {
            if ( id != cliente.Id )
            {
                return NotFound( );
            }

            if ( ModelState.IsValid )
            {
                try
                {
                    _clienteRepository.UpdateAsync(cliente).GetAwaiter( );
                    //await _clienteRepository.( );
                }
                catch ( DbUpdateConcurrencyException )
                {

                    if ( !await _clienteRepository.ExistAsync(id) )
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
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete ( int? id )
        {
            if ( id == null )
            {
                return NotFound( );
            }

            var cliente = await _clienteRepository.GetClienteByIdAsync(( int ) id);

            if ( cliente == null )
            {
                return NotFound( );
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed ( int id )
        {
            var cliente = await _clienteRepository.GetClienteByIdAsync(id);
            _clienteRepository.DeleteAsync(cliente);
            await _clienteRepository.GuardarCambiosAsync( );
            return RedirectToAction(nameof(Index));
        }

        //private bool ClienteExists ( int id )
        //{
        //    return _context.Clientes.Any(e => e.Id == id);

        //}
    }
}
