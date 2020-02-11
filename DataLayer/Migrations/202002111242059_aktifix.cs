namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aktifix : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PersonalAktivitet", new[] { "Aktivitet_AktivitetID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.PersonalAktivitet", "Aktivitet_AktivitetID", unique: true);
        }
    }
}
