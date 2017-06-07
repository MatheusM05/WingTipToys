namespace WingTipToys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtos", "Categoria_CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "Categoria_CategoriaId" });
            RenameColumn(table: "dbo.Produtos", name: "Categoria_CategoriaId", newName: "CategoriaId");
            AddColumn("dbo.Produtos", "ProdutoImagem", c => c.String());
            AlterColumn("dbo.Produtos", "CategoriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Produtos", "CategoriaId");
            AddForeignKey("dbo.Produtos", "CategoriaId", "dbo.Categorias", "CategoriaId", cascadeDelete: true);
            DropColumn("dbo.Produtos", "ProdutoImage");
            DropColumn("dbo.Produtos", "CategoriaIdll");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtos", "CategoriaIdll", c => c.Int(nullable: false));
            AddColumn("dbo.Produtos", "ProdutoImage", c => c.String());
            DropForeignKey("dbo.Produtos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "CategoriaId" });
            AlterColumn("dbo.Produtos", "CategoriaId", c => c.Int());
            DropColumn("dbo.Produtos", "ProdutoImagem");
            RenameColumn(table: "dbo.Produtos", name: "CategoriaId", newName: "Categoria_CategoriaId");
            CreateIndex("dbo.Produtos", "Categoria_CategoriaId");
            AddForeignKey("dbo.Produtos", "Categoria_CategoriaId", "dbo.Categorias", "CategoriaId");
        }
    }
}
