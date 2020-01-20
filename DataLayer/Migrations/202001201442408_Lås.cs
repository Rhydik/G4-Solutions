namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lås : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lås",
                c => new
                    {
                        LåsID = c.Int(nullable: false, identity: true),
                        Intäktsbudget = c.Boolean(nullable: false),
                        Kostnadsbudget = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LåsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lås");
        }
    }
}
