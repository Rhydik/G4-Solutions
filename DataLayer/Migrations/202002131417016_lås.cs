namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lås : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lås", "Kostnadsbudget", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lås", "Kostnadsbudget");
        }
    }
}
