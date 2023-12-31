using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMysqlRedesEletricasInteligentes.Models;
using ApiMysqlRedesEletricasInteligentes.Api;
using ApiMysqlRedesEletricasInteligentes.ModelApi;

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
        public async Task<ActionResult<IEnumerable<Nivel2Api>>?> GetNivel2s()
        {
            var nivel2 = await _context.Nivel2s.Select(p => new { p.Id, p.Projeto, p.Nivel1, p.Descricao }).ToListAsync();

            return Ok(nivel2);
        }

        // GET: api/Nivel1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Nivel2Api>>?> GetNivel2(int id)
        {
            var nivel2 = await _context.Nivel2s.Where(p => p.Id.ToString().Contains(id.ToString())).Select(p => new { p.Id, p.Projeto, p.Nivel1, p.Descricao }).ToListAsync();
            if (nivel2.Count == 0)
                return null;
            else
                return Ok(nivel2);
        }

        // PUT: api/Nivel2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNivel2(Nivel2Api nivel2Model)
        {
            var nivel2 = new Nivel2();
            nivel2.Id = nivel2Model.id;
            nivel2.Projeto = nivel2Model.projeto;
            nivel2.Nivel1 = nivel2Model.nivel1;
            nivel2.Descricao = nivel2Model.descricao;

            _context.Entry(nivel2).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Nivel2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nivel2>> PostNivel2(Nivel2Api nivel2Model)
        {
            var nivel2 = new Nivel2();
            nivel2.Projeto = nivel2Model.projeto;
            nivel2.Nivel1 = nivel2Model.nivel1;
            nivel2.Descricao = nivel2Model.descricao;

            _context.Nivel2s.Add(nivel2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNivel2", new { id = nivel2.Id }, nivel2);
        }

        // DELETE: api/Nivel2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNivel2(Nivel2Api nivel2Model)
        {
            var nivel2 = new Nivel2();
            nivel2.Id = nivel2Model.id;
            nivel2.Projeto = nivel2Model.projeto;
            nivel2.Nivel1 = nivel2Model.nivel1;
            nivel2.Descricao = nivel2Model.descricao;

            _context.Nivel2s.Remove(nivel2);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
