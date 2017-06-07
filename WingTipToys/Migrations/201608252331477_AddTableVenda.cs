namespace WingTipToys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        CarrinhoId = c.String(),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            DropColumn("dbo.Clientes", "CarrinhoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "CarrinhoId", c => c.String());
            DropForeignKey("dbo.Vendas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Vendas", new[] { "ClienteId" });
            DropTable("dbo.Vendas");
        }
    }
}
