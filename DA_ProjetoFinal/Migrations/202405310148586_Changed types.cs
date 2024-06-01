namespace DA_ProjetoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedtypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Utilizadors", "Nif", c => c.String());
            AlterColumn("dbo.Utilizadors", "NumEstudante", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilizadors", "NumEstudante", c => c.Int());
            AlterColumn("dbo.Utilizadors", "Nif", c => c.Int(nullable: false));
        }
    }
}
