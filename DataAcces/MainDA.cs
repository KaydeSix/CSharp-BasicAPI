using BasicApi.ViewData;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace BasicApi.DataAcces
{
    public class MainDA : DbContext
    {
        public MainDA(DbContextOptions<MainDA> options)
            : base(options) 
        {

        }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<VendaModel> Venda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //public List<ClienteModel> GetClientes()
        //{
        //    List<ClienteModel> ResultCliente = new List<ClienteModel>();
        //    string sql = "SELECT * FROM CLIENTE";

        //    SqlCommand cmd = new SqlCommand(sql);
        //    cmd.CommandType = System.Data.CommandType.Text;
        //    //cmd.Parameters.Add("",);
        //    //using (SqlDataReader reader = cmd.ExecuteReader())
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        ClienteModel vo = new ClienteModel()
        //        {
        //            IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]),
        //            NmCliente = dr["NM_CLIENTE"].ToString(),
        //            Cidade = dr["CIDADE"].ToString()
        //        };
        //        ResultCliente.Add(vo);
        //    }
        //    return ResultCliente;
        //}
    }
}
