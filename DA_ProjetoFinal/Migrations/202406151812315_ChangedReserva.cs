namespace DA_ProjetoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedReserva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservas", "Data");
        }
    }
}
