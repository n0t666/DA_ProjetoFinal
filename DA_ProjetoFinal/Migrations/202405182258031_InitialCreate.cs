namespace DA_ProjetoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nome = c.String(),
                        Nif = c.Int(nullable: false),
                        FotoDePerfil = c.String(),
                        NumEstudante = c.Int(),
                        Email = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Cliente_Id = c.Int(),
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.ItemFaturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fatura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faturas", t => t.Fatura_Id)
                .Index(t => t.Fatura_Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        PrecoEstudante = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoProfessor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente_Id = c.Int(),
                        Menu_Id = c.Int(),
                        Multa_Id = c.Int(),
                        Prato_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Multas", t => t.Multa_Id)
                .ForeignKey("dbo.Pratos", t => t.Prato_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Multa_Id)
                .Index(t => t.Prato_Id);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumeroHoras = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pratos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tipo = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExtraMenus",
                c => new
                    {
                        Extra_Id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Extra_Id, t.Menu_Id })
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .Index(t => t.Extra_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.ReservaExtras",
                c => new
                    {
                        Reserva_Id = c.Int(nullable: false),
                        Extra_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reserva_Id, t.Extra_Id })
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id, cascadeDelete: true)
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .Index(t => t.Reserva_Id)
                .Index(t => t.Extra_Id);
            
            CreateTable(
                "dbo.PratoMenus",
                c => new
                    {
                        Prato_Id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Prato_Id, t.Menu_Id })
                .ForeignKey("dbo.Pratos", t => t.Prato_Id, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .Index(t => t.Prato_Id)
                .Index(t => t.Menu_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Prato_Id", "dbo.Pratos");
            DropForeignKey("dbo.PratoMenus", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.PratoMenus", "Prato_Id", "dbo.Pratos");
            DropForeignKey("dbo.Faturas", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Reservas", "Multa_Id", "dbo.Multas");
            DropForeignKey("dbo.Reservas", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.ReservaExtras", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.ReservaExtras", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.ExtraMenus", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.ExtraMenus", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.ItemFaturas", "Fatura_Id", "dbo.Faturas");
            DropForeignKey("dbo.Faturas", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.PratoMenus", new[] { "Menu_Id" });
            DropIndex("dbo.PratoMenus", new[] { "Prato_Id" });
            DropIndex("dbo.ReservaExtras", new[] { "Extra_Id" });
            DropIndex("dbo.ReservaExtras", new[] { "Reserva_Id" });
            DropIndex("dbo.ExtraMenus", new[] { "Menu_Id" });
            DropIndex("dbo.ExtraMenus", new[] { "Extra_Id" });
            DropIndex("dbo.Reservas", new[] { "Prato_Id" });
            DropIndex("dbo.Reservas", new[] { "Multa_Id" });
            DropIndex("dbo.Reservas", new[] { "Menu_Id" });
            DropIndex("dbo.Reservas", new[] { "Cliente_Id" });
            DropIndex("dbo.ItemFaturas", new[] { "Fatura_Id" });
            DropIndex("dbo.Faturas", new[] { "Menu_Id" });
            DropIndex("dbo.Faturas", new[] { "Cliente_Id" });
            DropTable("dbo.PratoMenus");
            DropTable("dbo.ReservaExtras");
            DropTable("dbo.ExtraMenus");
            DropTable("dbo.Pratos");
            DropTable("dbo.Multas");
            DropTable("dbo.Reservas");
            DropTable("dbo.Extras");
            DropTable("dbo.Menus");
            DropTable("dbo.ItemFaturas");
            DropTable("dbo.Faturas");
            DropTable("dbo.Clientes");
        }
    }
}
