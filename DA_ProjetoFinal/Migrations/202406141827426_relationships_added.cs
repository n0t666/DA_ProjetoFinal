namespace DA_ProjetoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationships_added : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservas", "Prato_Id", "dbo.Pratos");
            DropIndex("dbo.Reservas", new[] { "Prato_Id" });
            CreateTable(
                "dbo.PratoReservas",
                c => new
                    {
                        Prato_Id = c.Int(nullable: false),
                        Reserva_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Prato_Id, t.Reserva_Id })
                .ForeignKey("dbo.Pratos", t => t.Prato_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id, cascadeDelete: true)
                .Index(t => t.Prato_Id)
                .Index(t => t.Reserva_Id);
            
            DropColumn("dbo.Reservas", "Prato_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservas", "Prato_Id", c => c.Int());
            DropForeignKey("dbo.PratoReservas", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.PratoReservas", "Prato_Id", "dbo.Pratos");
            DropIndex("dbo.PratoReservas", new[] { "Reserva_Id" });
            DropIndex("dbo.PratoReservas", new[] { "Prato_Id" });
            DropTable("dbo.PratoReservas");
            CreateIndex("dbo.Reservas", "Prato_Id");
            AddForeignKey("dbo.Reservas", "Prato_Id", "dbo.Pratos", "Id");
        }
    }
}
