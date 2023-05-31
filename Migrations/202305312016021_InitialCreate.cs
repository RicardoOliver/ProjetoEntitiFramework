namespace Negocio.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompraMercadoriaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Compra = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        LembrarMe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NomeMercadoriaModes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrecoMercadoriaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuantidadeMercadoriaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoMercadoriaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsuarioModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VendaMercadoriaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Venda = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VendaMercadoriaModels");
            DropTable("dbo.UsuarioModels");
            DropTable("dbo.TipoMercadoriaModels");
            DropTable("dbo.QuantidadeMercadoriaModels");
            DropTable("dbo.PrecoMercadoriaModels");
            DropTable("dbo.NomeMercadoriaModes");
            DropTable("dbo.LoginViewModels");
            DropTable("dbo.CompraMercadoriaModels");
        }
    }
}
