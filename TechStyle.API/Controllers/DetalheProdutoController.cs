using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechStyle.API.DTO;
using TechStyle.Dados.Repositorio;
using TechStyle.Dominio.Modelo;

namespace TechStyle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalheProdutoController : ControllerBase
    {
        private readonly DetalheProdutoRepositorio _repoDetalheProduto;

        public DetalheProdutoController()
        {
            _repoDetalheProduto = new DetalheProdutoRepositorio();
        }

        [HttpGet]
        public IEnumerable<DetalheProduto> Get()
        {
            return _repoDetalheProduto.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public DetalheProduto Get(int id)
        {
            return _repoDetalheProduto.SelecionarPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] DetalheProdutoDTO dto)
        {
            var detalheProduto = new DetalheProduto();
            detalheProduto.Cadastrar(dto.Tamanho, dto.Marca, dto.Material, dto.Modelo, dto.Cor);

            _repoDetalheProduto.Incluir(detalheProduto);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DetalheProdutoDTO dto)
        {
            var detalheProduto = new DetalheProduto();
            detalheProduto.Alterar(id, dto.Tamanho, dto.Marca, dto.Material, dto.Modelo, dto.Cor);

            _repoDetalheProduto.Alterar(detalheProduto);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repoDetalheProduto.AlterarStatus(id);
        }
    }
}
