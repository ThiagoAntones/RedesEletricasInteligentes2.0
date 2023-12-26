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
    public class Nivel1Controller : ControllerBase
    {
        private readonly DbRedesinteContext _context;

        public Nivel1Controller(DbRedesinteContext context)
        {
            _context = context;
        }

        // GET: api/Nivel1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nivel1>>> GetNivel1s()
        {
          if (_context.Nivel1s == null)
          {
              return NotFound();
          }
            return await _context.Nivel1s.ToListAsync();
        }

        // GET: api/Nivel1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nivel1>> GetNivel1(int id)
        {
          if (_context.Nivel1s == null)
          {
              return NotFound();
          }
            var nivel1 = await _context.Nivel1s.FindAsync(id);

            if (nivel1 == null)
            {
                return NotFound();
            }

            return nivel1;
        }

        // PUT: api/Nivel1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNivel1(int id, Nivel1 nivel1)
        {
            if (id != nivel1.Id)
            {
                return BadRequest();
            }

            _context.Entry(nivel1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Nivel1Exists(id))
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

        // POST: api/Nivel1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nivel1>> PostNivel1(Nivel1 nivel1)
        {
          if (_context.Nivel1s == null)
          {
              return Problem("Entity set 'DbRedesinteContext.Nivel1s'  is null.");
          }
            _context.Nivel1s.Add(nivel1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNivel1", new { id = nivel1.Id }, nivel1);
        }

        // DELETE: api/Nivel1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNivel1(int id)
        {
            if (_context.Nivel1s == null)
            {
                return NotFound();
            }
            var nivel1 = await _context.Nivel1s.FindAsync(id);
            if (nivel1 == null)
            {
                return NotFound();
            }

            _context.Nivel1s.Remove(nivel1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Nivel1Exists(int id)
        {
            return (_context.Nivel1s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
