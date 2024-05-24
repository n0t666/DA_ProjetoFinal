namespace DA_ProjetoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Utilizadors");
            AddColumn("dbo.Utilizadors", "Username", c => c.String());
            AlterColumn("dbo.Utilizadors", "Saldo", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilizadors", "Saldo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Utilizadors", "Username");
            RenameTable(name: "dbo.Utilizadors", newName: "Clientes");
        }
    }
}
