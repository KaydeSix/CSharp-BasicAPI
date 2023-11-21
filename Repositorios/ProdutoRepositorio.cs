using BasicApi.DataAcces;
using BasicApi.Repositorios.Interfaces;
using BasicApi.ViewData;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly MainDA _dbProduto;
        public ProdutoRepositorio(MainDA ProdutoDA)
        {
            _dbProduto = ProdutoDA;
        }
        public async Task<List<ProdutoModel>> GetProdutos()
        {
            return await _dbProduto.Produto.ToListAsync();
        }
        public async Task<ProdutoModel> GetProdutoByDescription(string DescricaoProduto)
        {
            return await _dbProduto.Produto.FirstOrDefaultAsync(x => x.DscProduto == DescricaoProduto);
        }
        public async Task<ProdutoModel> GetProdutoById(int IdProduto)
        {
            return await _dbProduto.Produto.FirstOrDefaultAsync(x => x.Id == IdProduto);
        }
        public async Task<ProdutoModel> InsertProduto(ProdutoModel NovoProduto)
        {
            await _dbProduto.Produto.AddAsync(NovoProduto);
            await _dbProduto.SaveChangesAsync();

            return NovoProduto;
        }
        public async Task<ProdutoModel> EditProduto(ProdutoModel EdicaoProduto, int IdProduto)
        {
            ProdutoModel Produto = await GetProdutoById(IdProduto);

            Produto.DscProduto = EdicaoProduto.DscProduto;
            Produto.VlrUnitario = EdicaoProduto.VlrUnitario;

            _dbProduto.Produto.Update(Produto);
            await _dbProduto.SaveChangesAsync();

            return Produto;
        }
        public async Task<bool> DeleteProduto(int IdProduto)
        {
            ProdutoModel Produto = await GetProdutoById(IdProduto);

            _dbProduto.Produto.Remove(Produto);
            await _dbProduto.SaveChangesAsync();

            return true;
        }
    }
}
