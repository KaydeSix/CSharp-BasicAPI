using Microsoft.OData.Edm;

namespace BasicApi.ViewData
{
    public class VendaModel
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public long QtdVenda { get; set; }
        public long VlrUnitarioVenda { get; set; }
        public long VlrTotalVenda { get; set; }
        public string DthVenda { get; set; }
    }
}

