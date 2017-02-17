namespace Vendas.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.adiantamentocliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa = c.String(nullable: false, maxLength: 100, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 15, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.adiantamentofornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa = c.String(nullable: false, maxLength: 100, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 15, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.adiantamentofornecedor");
            DropTable("dbo.adiantamentocliente");
        }
    }
}
