namespace WingTipToys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UptadeTableClienteAddTelefone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Endereco", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Clientes", "Telefone", c => c.String(nullable: false, maxLength: 15));
            DropColumn("dbo.Clientes", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Email", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Clientes", "Telefone");
            DropColumn("dbo.Clientes", "Endereco");
        }
    }
}
