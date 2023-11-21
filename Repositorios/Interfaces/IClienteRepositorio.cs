using BasicApi.ViewData;

namespace BasicApi.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> GetClientes();
        Task<ClienteModel> GetClienteByName(string NomeCliente);
        Task<ClienteModel> GetClienteById(int IdCliente);
        Task<ClienteModel> InsertCliente(ClienteModel NovoCliente);
        Task<ClienteModel> EditCliente(ClienteModel EdicaoCliente, int IdCliente);
        Task<bool> DeleteCliente(int IdCliente);
    }
}
