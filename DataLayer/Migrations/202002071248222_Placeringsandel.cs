namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Placeringsandel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalProdukt", "Placeringsandel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonalProdukt", "Placeringsandel");
        }
    }
}
