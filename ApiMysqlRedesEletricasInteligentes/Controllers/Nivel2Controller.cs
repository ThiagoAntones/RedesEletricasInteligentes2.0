using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMysqlRedesEletricasInteligentes.Models;

namespace ApiMysqlRedesEletricasInteligentes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Nivel2Controller : ControllerBase
    {
        private readonly DbRedesinteContext _context;

        public Nivel2Controller(DbRedesinteContext context)
        {
            _context = context;
        }

        // GET: api/Nivel2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nivel2>>> GetNivel2s()
        {
          if (_context.Nivel2s == null)
          {
              return NotFound();
          }
            return await _context.Nivel2s.ToListAsync();
        }

        // GET: api/Nivel2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nivel2>> GetNivel2(int id)
        {
          if (_context.Nivel2s == null)
          {
              return NotFound();
          }
            var nivel2 = await _context.Nivel2s.FindAsync(id);

            if (nivel2 == null)
            {
                return NotFound();
            }

            return nivel2;
        }

        // PUT: api/Nivel2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNivel2(int id, Nivel2 nivel2)
        {
            if (id != nivel2.Id)
            {
                return BadRequest();
            }

            _context.Entry(nivel2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Nivel2Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Nivel2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nivel2>> PostNivel2(Nivel2 nivel2)
        {
          if (_context.Nivel2s == null)
          {
              return Problem("Entity set 'DbRedesinteContext.Nivel2s'  is null.");
          }
            _context.Nivel2s.Add(nivel2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNivel2", new { id = nivel2.Id }, nivel2);
        }

        // DELETE: api/Nivel2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNivel2(int id)
        {
            if (_context.Nivel2s == null)
            {
                return NotFound();
            }
            var nivel2 = await _context.Nivel2s.FindAsync(id);
            if (nivel2 == null)
            {
                return NotFound();
            }

            _context.Nivel2s.Remove(nivel2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Nivel2Exists(int id)
        {
            return (_context.Nivel2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
