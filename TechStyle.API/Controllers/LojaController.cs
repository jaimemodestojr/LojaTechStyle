using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechStyle.API.DTO;
using TechStyle.Dados.Repositorio;
using TechStyle.Dominio.Modelo;

namespace TechStyle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojaController : ControllerBase
    {
        private readonly LojaRepositorio _repoLoja;

        public LojaController()
        {
            _repoLoja = new LojaRepositorio();
        }

        [HttpGet]
        public IEnumerable<Loja> Get()
        {
            return _repoLoja.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Loja Get(int id)
        {
            return _repoLoja.SelecionarPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] LojaDTO dto)
        {
            var loja = new Loja();
            loja.Alterar(dto.QuantidadeMinima);

            _repoLoja.Alterar(loja);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LojaDTO dto)
        {
            var loja = new Loja();
            loja.Alterar(id, dto.QuantidadeLocal);

            _repoLoja.Alterar(loja);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repoLoja.AlterarStatus(id);
        }
    }
}
