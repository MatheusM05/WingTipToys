namespace WingTipToys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableClienteUpdateCarrinhoId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "CarrinhoId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "CarrinhoId", c => c.Int(nullable: false));
        }
    }
}
