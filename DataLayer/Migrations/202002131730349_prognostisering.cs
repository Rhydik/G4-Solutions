namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prognostisering : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lås", "Prognostisering", c => c.Boolean(nullable: false));
            DropColumn("dbo.Lås", "Kostnadsbudget");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lås", "Kostnadsbudget", c => c.Boolean(nullable: false));
            DropColumn("dbo.Lås", "Prognostisering");
        }
    }
}
