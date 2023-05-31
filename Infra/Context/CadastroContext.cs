
using Negocio.Web.Models;
using System.Data.Common;
using System.Data.Entity;


namespace Negocio.Web.Infra.Context
{
    public class CadastroContext : DbContext
    {

        public DbSet<CompraMercadoriaModel> compraMercadoriaModels { get; set; }
        
        public DbSet<LoginViewModel> loginViewModels { get; set; }

        public DbSet<NomeMercadoriaModel> nomeMercadoriaModels { get; set; }

        public DbSet<PrecoMercadoriaModel> precoMercadoriaModels { get; set; }

        public DbSet<QuantidadeMercadoriaModel> quantidadeMercadoriaModels { get; set; }

        public DbSet<TipoMercadoriaModel> tipoMercadoriaModels { get; set; }

        public DbSet<UsuarioModel> usuarioModels { get; set; }

        public DbSet<VendaMercadoriaModel> vendaMercadoriaModels { get; set; }

        public CadastroContext(string connectionString)
        : base(connectionString)
        {
            InitializeContext();
        }
        public CadastroContext()
            : base("Key name on App.Config/Web.Config")
        {
            InitializeContext();
        }
        public CadastroContext(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
            InitializeContext();
        }
        private void InitializeContext()
        {
            Database.SetInitializer<CadastroContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompraMercadoriaModel>().ToTable("CompraMercadoriaModels");
            modelBuilder.Entity<LoginViewModel>().ToTable("LoginViewModels");
            modelBuilder.Entity<NomeMercadoriaModel>().ToTable("NomeMercadoriaModes");
            modelBuilder.Entity<PrecoMercadoriaModel>().ToTable("PrecoMercadoriaModels");
            modelBuilder.Entity<QuantidadeMercadoriaModel>().ToTable("QuantidadeMercadoriaModels");
            modelBuilder.Entity<TipoMercadoriaModel>().ToTable("TipoMercadoriaModels");
            modelBuilder.Entity<UsuarioModel>().ToTable("UsuarioModels");
            modelBuilder.Entity<VendaMercadoriaModel>().ToTable("VendaMercadoriaModels");
            base.OnModelCreating(modelBuilder);
        }
    }
}
