using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechStyle.API.DTO;
using TechStyle.Dados.Repositorio;
using TechStyle.Dominio.Modelo;

namespace TechStyle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepositorio _repoProduto;

        public ProdutoController()
        {
            _repoProduto = new ProdutoRepositorio();
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _repoProduto.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return _repoProduto.SelecionarPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] ProdutoDTO dto)
        {
            var produto = new Produto();
            produto.Alterar(dto.ValorVenda);

            _repoProduto.Alterar(produto);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProdutoDTO dto)
        {
            var produto = new Produto();
            produto.Alterar(id, dto.Nome, dto.SKU);

            _repoProduto.Incluir(produto);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repoProduto.AlterarStatus(id);
        }
    }
}
