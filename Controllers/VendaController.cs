using BasicApi.Repositorios.Interfaces;
using BasicApi.ViewData;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly IVendaRepositorio _vendaRepositorio;
        public VendaController(IVendaRepositorio vendaRepositorio)
        {
            _vendaRepositorio = vendaRepositorio;
        }
        [HttpGet]
        [Route("GetVendas")]
        public async Task<ActionResult<List<VendaModel>>> GetVendas()
        {
            List<VendaModel> listaVendas = await _vendaRepositorio.GetVendas();
            return Ok(listaVendas);
        }
        [HttpPost]
        [Route("InsertVenda")]
        public async Task<ActionResult<VendaModel>> InsertVenda(VendaModel NovaVenda)
        {
            VendaModel VendaNova = await _vendaRepositorio.InsertVenda(NovaVenda);
            return Ok(VendaNova);
        }
        [HttpPut]
        [Route("EditVenda")]
        public async Task<ActionResult<VendaModel>> EditVenda(VendaModel Venda, int IdVenda)
        {
            VendaModel vendaEditado = await _vendaRepositorio.EditVenda(Venda, IdVenda);
            return Ok(vendaEditado);
        }
        [HttpDelete]
        [Route("DeleteVenda")]
        public async Task<ActionResult<bool>> DeleteVenda(int IdVenda)
        {
            bool delete = await _vendaRepositorio.DeleteVenda(IdVenda);
            return Ok(delete);
        }
    }
}
