using BasicApi.DataAcces;
using BasicApi.Repositorios.Interfaces;
using BasicApi.ViewData;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly MainDA _dbCliente;
        public ClienteRepositorio(MainDA ClienteDA)
        {
            _dbCliente = ClienteDA;
        }
        public async Task<List<ClienteModel>> GetClientes()
        {
            //return await _dbCliente.Cliente.ToListAsync();
            return await _dbCliente.Cliente.FromSql($"SELECT * FROM CLIENTE").ToListAsync();
        }
        public async Task<ClienteModel> GetClienteByName(string NomeCliente)
        {
            return await _dbCliente.Cliente.FirstOrDefaultAsync(x => x.NmCliente == NomeCliente);
        }
        public async Task<ClienteModel> GetClienteById(int IdCliente)
        {
            return await _dbCliente.Cliente.FirstOrDefaultAsync(x => x.Id == IdCliente);
        }
        public async Task<ClienteModel> InsertCliente(ClienteModel NovoCliente)
        {
            await _dbCliente.Cliente.AddAsync(NovoCliente);
            await _dbCliente.SaveChangesAsync();

            return NovoCliente;
        }
        public async Task<ClienteModel> EditCliente(ClienteModel EdicaoCliente, int IdCliente)
        {
            ClienteModel Cliente = await GetClienteById(IdCliente);

            Cliente.NmCliente = EdicaoCliente.NmCliente;
            Cliente.Cidade = EdicaoCliente.Cidade;

            _dbCliente.Cliente.Update(Cliente);
            await _dbCliente.SaveChangesAsync();

            return Cliente;
        }
        public async Task<bool> DeleteCliente(int IdCliente)
        {
            ClienteModel Cliente = await GetClienteById(IdCliente);

            _dbCliente.Cliente.Remove(Cliente);
            await _dbCliente.SaveChangesAsync();

            return true;
        }

    }
}
