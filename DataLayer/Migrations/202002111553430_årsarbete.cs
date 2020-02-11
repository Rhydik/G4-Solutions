namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class årsarbete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personal", "Årsarbete", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personal", "Årsarbete");
        }
    }
}
