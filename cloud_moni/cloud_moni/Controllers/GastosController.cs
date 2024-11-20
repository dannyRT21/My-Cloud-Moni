using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cloud_moni.models;

namespace cloud_moni.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GastosController : ControllerBase
    {
        private readonly MyDbContext _context;

        public GastosController(MyDbContext context)
        {
            _context = context;
        }

        // Método para obtener todos los gastos de un usuario
        [HttpGet("usuario/{idUsuario}")]
        public async Task<ActionResult<IEnumerable<Gastos>>> GastUsuario(int idUsuario)
        {
            var gastos = await _context.Gastos.Where(g => g.IdUsuario == idUsuario).ToListAsync();
            return Ok(gastos);
        }

        // Método para obtener un gasto específico
        [HttpGet("{idGasto}")]
        public async Task<ActionResult<Gastos>> GetGasto(int idGasto)
        {
            var gasto = await _context.Gastos.FindAsync(idGasto);
            if (gasto == null)
            {
                return NotFound();
            }
            return Ok(gasto);
        }

        // Crear un nuevo gasto
        [HttpPost]
        public async Task<ActionResult<Usuarios>> CreateGasto(Gastos gasto)
        {
            _context.Gastos.Add(gasto);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetGasto", new { id = gasto.IdGasto }, gasto);
        }

        // Actualizar un gasto existente
        [HttpPut("{id}")]
        public IActionResult UpdateGasto(int id, [FromBody] Gastos gasto)
        {
            var gastoExistente = _context.Gastos.Find(id);
            if (gastoExistente == null) return NotFound();

            gastoExistente.Categoria = gasto.Categoria;
            gastoExistente.Fecha = gasto.Fecha;
            gastoExistente.Concepto = gasto.Concepto;
            gastoExistente.Total = gasto.Total;

            _context.SaveChanges();
            return Ok(gastoExistente);
        }

        // Eliminar un gasto
        [HttpDelete("{id}")]
        public IActionResult DeleteGasto(int id)
        {
            var gasto = _context.Gastos.Find(id);
            if (gasto == null) return NotFound();

            _context.Gastos.Remove(gasto);
            _context.SaveChanges();
            return Ok();
        }
    }
}
