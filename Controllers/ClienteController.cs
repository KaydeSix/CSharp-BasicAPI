using BasicApi.DataAcces;
using BasicApi.Repositorios.Interfaces;
using BasicApi.ViewData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        [HttpGet]
        [Route("GetClientes")]
        public async Task<ActionResult<List<ClienteModel>>> GetClientes()
        {
            List<ClienteModel> listaUsuarios = await _clienteRepositorio.GetClientes();
            return Ok(listaUsuarios);
        }
        [HttpGet]
        [Route("GetClienteByName")]
        public async Task<ActionResult<ClienteModel>> GetClienteByName(string NomeCliente)
        {
            ClienteModel cliente = await _clienteRepositorio.GetClienteByName(NomeCliente);
            return Ok(cliente);
        }
        [HttpPost]
        [Route("InsertCliente")]
        public async Task<ActionResult<ClienteModel>> InsertCliente(ClienteModel ClienteNovo)
        {
            ClienteModel clienteNovo = await _clienteRepositorio.InsertCliente(ClienteNovo);
            return Ok(clienteNovo);
        }
        [HttpPut]
        [Route("EditCliente")]
        public async Task<ActionResult<ClienteModel>> EditCliente(ClienteModel Cliente, int IdCliente)
        {
            ClienteModel clienteEditado = await _clienteRepositorio.EditCliente(Cliente, IdCliente);
            return Ok(clienteEditado);
        }
        [HttpDelete]
        [Route("DeleteCliente")]
        public async Task<ActionResult<bool>> DeleteCliente(int IdCliente)
        {
            bool delete = await _clienteRepositorio.DeleteCliente(IdCliente);
            return Ok(delete);
        }
    }
}
