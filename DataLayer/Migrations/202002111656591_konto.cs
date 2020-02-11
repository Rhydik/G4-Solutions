namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class konto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Konto", "konto", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Konto", "konto", c => c.String(nullable: false));
        }
    }
}
