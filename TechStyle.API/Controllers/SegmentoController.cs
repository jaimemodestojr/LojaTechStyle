using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechStyle.API.DTO;
using TechStyle.Dados.Repositorio;
using TechStyle.Dominio.Modelo;

namespace TechStyle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegmentoController : ControllerBase
    {
        private readonly SegmentoRepositorio _repoSegmento;      

        public SegmentoController()
        {
            _repoSegmento = new SegmentoRepositorio();
        }

        [HttpGet]
        public IEnumerable<Segmento> Get()
        {
            return _repoSegmento.SelecionarTudo();
        }
        
        [HttpGet("{id}")]
        public Segmento Get(int id)
        {
            return _repoSegmento.SelecionarPorId(id);
        }
        
        [HttpPost]
        public void Post([FromBody] SegmentoDTO dto)
        {
            var segmento = new Segmento();
            segmento.Cadastrar(dto.Categoria, dto.Subcategoria);

            _repoSegmento.Incluir(segmento);
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SegmentoDTO dto)
        {
            var segmento = new Segmento();
            segmento.Alterar(id, dto.Categoria, dto.Subcategoria);

            _repoSegmento.Alterar(segmento);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repoSegmento.AlterarStatus(id);
        }
    }
}
