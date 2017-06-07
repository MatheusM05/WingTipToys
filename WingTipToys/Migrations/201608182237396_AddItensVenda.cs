namespace WingTipToys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItensVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemVendas",
                c => new
                    {
                        ItemVendaId = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        CarrinhoId = c.String(),
                    })
                .PrimaryKey(t => t.ItemVendaId)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVendas", "ProdutoId", "dbo.Produtos");
            DropIndex("dbo.ItemVendas", new[] { "ProdutoId" });
            DropTable("dbo.ItemVendas");
        }
    }
}
