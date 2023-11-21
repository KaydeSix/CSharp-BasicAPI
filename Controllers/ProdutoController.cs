using BasicApi.Repositorios;
using BasicApi.Repositorios.Interfaces;
using BasicApi.ViewData;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        [HttpGet]
        [Route("GetProdutos")]
        public async Task<ActionResult<List<ProdutoModel>>> GetProdutos()
        {
            List<ProdutoModel> listaProdutos = await _produtoRepositorio.GetProdutos();
            return Ok(listaProdutos);
        }
        [HttpGet]
        [Route("GetProdutoByDescription")]
        public async Task<ActionResult<ProdutoModel>> GetProdutoByDescription(string DescricaoProduto)
        {
            ProdutoModel produto = await _produtoRepositorio.GetProdutoByDescription(DescricaoProduto);
            return Ok(produto);
        }
        [HttpPost]
        [Route("InsertProduto")]
        public async Task<ActionResult<ProdutoModel>> InsertProduto(ProdutoModel ProdutoNovo)
        {
            ProdutoModel produtoNovo = await _produtoRepositorio.InsertProduto(ProdutoNovo);
            return Ok(produtoNovo);
        }
        [HttpPut]
        [Route("EditProduto")]
        public async Task<ActionResult<ProdutoModel>> EditProduto(ProdutoModel Produto, int IdProduto)
        {
            ProdutoModel produtoEditado = await _produtoRepositorio.EditProduto(Produto, IdProduto);
            return Ok(produtoEditado);
        }
        [HttpDelete]
        [Route("DeleteProduto")]
        public async Task<ActionResult<bool>> DeleteProduto(int IdProduto)
        {
            bool delete = await _produtoRepositorio.DeleteProduto(IdProduto);
            return Ok(delete);
        }
    }
}
