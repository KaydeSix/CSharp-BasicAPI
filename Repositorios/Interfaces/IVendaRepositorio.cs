using BasicApi.ViewData;

namespace BasicApi.Repositorios.Interfaces
{
    public interface IVendaRepositorio
    {
        Task<List<VendaModel>> GetVendas();
        Task<VendaModel> GetVendaById(int IdVenda);
        Task<VendaModel> InsertVenda(VendaModel NovaVenda);
        Task<VendaModel> EditVenda(VendaModel EdicaoVenda, int IdVenda);
        Task<bool> DeleteVenda(int IdVenda);
    }
}
