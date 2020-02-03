namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLås : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Lås", name: "Kostnadsbudget", newName: "AffoAvdelning");
            AddColumn("dbo.Lås", "DriftAvdelning", c => c.Boolean(nullable: false));
            AddColumn("dbo.Lås", "UtvFörvAvdelning", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
