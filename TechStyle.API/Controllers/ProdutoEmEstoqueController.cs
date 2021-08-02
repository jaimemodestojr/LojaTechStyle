using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechStyle.API.DTO;
using TechStyle.Dados.Repositorio;
using TechStyle.Dominio.Modelo;

namespace TechStyle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoEmEstoqueController : ControllerBase
    {
        private readonly EstoqueRepositorio _repoProdutoEmEstoque;

        public ProdutoEmEstoqueController()
        {
            _repoProdutoEmEstoque = new EstoqueRepositorio();
        }

        [HttpGet]
        public IEnumerable<ProdutoEmEstoque> Get()
        {
            return _repoProdutoEmEstoque.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public ProdutoEmEstoque Get(int id)
        {
            return _repoProdutoEmEstoque.SelecionarPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] ProdutoEmEstoqueDTO dto)
        {
            var produtoEmEstoque = new ProdutoEmEstoque();
            produtoEmEstoque.AlterarEstoque(dto.Local, dto.QuantidadeMinima);

            _repoProdutoEmEstoque.AlterarEstoque(produtoEmEstoque);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProdutoEmEstoqueDTO dto)
        {
            var produtoEmEstoque = new ProdutoEmEstoque();
            produtoEmEstoque.IncluirQuantidade(id, dto.QuantidadeLocal, dto.QuantidadeTotal);

            _repoProdutoEmEstoque.IncluirQuantidade(produtoEmEstoque);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repoProdutoEmEstoque.AlterarStatus(id);
        }
    }
}
