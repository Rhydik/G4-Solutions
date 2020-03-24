namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intTillDecida : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AvdelningPersonalxRef", "Placering", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PersonalAktivitet", "Placeringsandel", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PersonalAktivitet", "Placeringsandel", c => c.Int(nullable: false));
            AlterColumn("dbo.AvdelningPersonalxRef", "Placering", c => c.Int(nullable: false));
        }
    }
}
