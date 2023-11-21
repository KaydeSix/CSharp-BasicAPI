using BasicApi.DataAcces;
using BasicApi.Repositorios.Interfaces;
using BasicApi.ViewData;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Repositorios
{
    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly MainDA _dbVenda;
        public VendaRepositorio(MainDA VendaDA)
        {
            _dbVenda = VendaDA;
        }
        public async Task<List<VendaModel>> GetVendas()
        {
            return await _dbVenda.Venda.ToListAsync();
        }
        public async Task<VendaModel> GetVendaById(int IdVenda)
        {
            return await _dbVenda.Venda.FirstOrDefaultAsync(x => x.Id == IdVenda);
        }
        public async Task<VendaModel> EditVenda(VendaModel EdicaoVenda, int IdVenda)
        {
            VendaModel Venda = await GetVendaById(IdVenda);

            Venda.QtdVenda = EdicaoVenda.QtdVenda;
            Venda.DthVenda = EdicaoVenda.DthVenda;
            Venda.VlrTotalVenda = EdicaoVenda.VlrTotalVenda;
            Venda.VlrUnitarioVenda = EdicaoVenda.VlrUnitarioVenda;

            _dbVenda.Venda.Update(Venda);
            await _dbVenda.SaveChangesAsync();

            return Venda;
        }
        public async Task<VendaModel> InsertVenda(VendaModel NovaVenda)
        {
            await _dbVenda.Venda.AddAsync(NovaVenda);
            await _dbVenda.SaveChangesAsync();

            return NovaVenda;
        }
        public async Task<bool> DeleteVenda(int IdVenda)
        {
            VendaModel Venda = await GetVendaById(IdVenda);

            _dbVenda.Venda.Remove(Venda);
            await _dbVenda.SaveChangesAsync();

            return true;
        }
    }
}
