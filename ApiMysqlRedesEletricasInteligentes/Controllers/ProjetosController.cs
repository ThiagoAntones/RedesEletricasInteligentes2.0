using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMysqlRedesEletricasInteligentes.Models;
using ApiMysqlRedesEletricasInteligentes.ModelApi;

namespace ApiMysqlRedesEletricasInteligentes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly DbRedesinteContext _context;

        public ProjetosController(DbRedesinteContext context)
        {
            _context = context;
        }

        // GET: api/Projetos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjetoApi>>?> GetProjetos()
        {
            var projetos = await _context.Projetos.Select(p => new { p.Id, p.Titulo, p.Descricao, p.Inicio, p.Termino, p.Custo }).ToListAsync();

            return Ok(projetos);
        }

        // GET: api/Projetos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ProjetoApi>>?> GetProjeto(int id)
        {
            var projetos = await _context.Projetos.Where(p => p.Id.ToString().Contains(id.ToString())).Select(p => new { p.Id, p.Titulo, p.Descricao, p.Inicio, p.Termino, p.Custo }).ToListAsync();
            if(projetos.Count == 0)
                return null;
            else
                return Ok(projetos);
        }

        // PUT: api/Projetos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjeto(ProjetoApi projetoModel)
        {
            var projeto = new Projeto();
            projeto.Id = projetoModel.id;
            projeto.Titulo = projetoModel.titulo;
            projeto.Descricao = projetoModel.descricao;
            projeto.Inicio = projetoModel.inicio;
            projeto.Termino = projetoModel.termino;
            projeto.Custo = projetoModel.custo;

            _context.Entry(projeto).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Projetos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Projeto>> PostProjeto(ProjetoApi projetoModel)
        {
            var projeto = new Projeto();
            projeto.Titulo = projetoModel.titulo;
            projeto.Descricao = projetoModel.descricao;
            projeto.Inicio = projetoModel.inicio;
            projeto.Termino = projetoModel.termino;
            projeto.Custo = projetoModel.custo;

            _context.Projetos.Add(projeto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjeto", new { id = projeto.Id }, projeto);
        }

        // DELETE: api/Projetos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjeto(ProjetoApi projetoModel)
        {
            var projeto = new Projeto();
            projeto.Id = projetoModel.id;
            projeto.Titulo = projetoModel.titulo;
            projeto.Descricao = projetoModel.descricao;
            projeto.Inicio = projetoModel.inicio;
            projeto.Termino = projetoModel.termino;
            projeto.Custo = projetoModel.custo;

            _context.Projetos.Remove(projeto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
