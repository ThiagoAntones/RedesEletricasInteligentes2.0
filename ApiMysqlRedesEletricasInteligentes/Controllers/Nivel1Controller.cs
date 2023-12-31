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
using Newtonsoft.Json;

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
        public async Task<ActionResult<IEnumerable<Nivel1Api>>?> GetNivel1s()
        {
            var nivel1 = await _context.Nivel1s.Select(p => new { p.Id, p.Projeto, p.Descricao }).ToListAsync();

            return Ok(nivel1);
        }

        // GET: api/Nivel1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Nivel1Api>>?> GetNivel1(int id)
        {
            var nivel1 = await _context.Nivel1s.Where(p => p.Id.ToString().Contains(id.ToString())).Select(p => new { p.Id, p.Projeto, p.Descricao }).ToListAsync();
            if (nivel1.Count == 0)
                return null;
            else
                return Ok(nivel1);
        }

        // PUT: api/Nivel1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNivel1(Nivel1Api nivel1Model)
        {
            var nivel1 = new Nivel1();
            nivel1.Id = nivel1Model.id;
            nivel1.Projeto = nivel1Model.projeto;
            nivel1.Descricao = nivel1Model.descricao;

            _context.Entry(nivel1).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Nivel1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nivel1>> PostNivel1(Nivel1Api nivel1Model)
        {
            var nivel1 = new Nivel1();
            nivel1.Projeto = nivel1Model.projeto;
            nivel1.Descricao = nivel1Model.descricao;

            _context.Nivel1s.Add(nivel1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNivel1", new { id = nivel1.Id }, nivel1);
        }

        // DELETE: api/Nivel1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNivel1(Nivel1Api nivel1Model)
        {
            var nivel1 = new Nivel1();
            nivel1.Id = nivel1Model.id;
            nivel1.Projeto = nivel1Model.projeto;
            nivel1.Descricao = nivel1Model.descricao;

            _context.Nivel1s.Remove(nivel1);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
