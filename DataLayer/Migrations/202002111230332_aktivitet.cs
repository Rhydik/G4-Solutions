namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aktivitet : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PersonalAktivitet");
            AddColumn("dbo.PersonalAktivitet", "Aktivitet_AktivitetID1", c => c.String(maxLength: 128, unicode: false));
            AlterColumn("dbo.Aktivitet", "AktivitetID", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AlterColumn("dbo.Aktivitet", "Namn", c => c.String());
            AlterColumn("dbo.PersonalAktivitet", "Aktivitet_AktivitetID", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.Aktivitet", "AktivitetID");
            AddPrimaryKey("dbo.PersonalAktivitet", new[] { "Personal_PersonalID", "Aktivitet_AktivitetID" });
            CreateIndex("dbo.Aktivitet", "AktivitetID", unique: true);
            CreateIndex("dbo.PersonalAktivitet", "Aktivitet_AktivitetID", unique: true);
            CreateIndex("dbo.PersonalAktivitet", "Aktivitet_AktivitetID1");
            AddForeignKey("dbo.PersonalAktivitet", "Aktivitet_AktivitetID1", "dbo.Aktivitet", "AktivitetID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonalAktivitet", "Aktivitet_AktivitetID1", "dbo.Aktivitet");
            DropIndex("dbo.PersonalAktivitet", new[] { "Aktivitet_AktivitetID1" });
            DropIndex("dbo.PersonalAktivitet", new[] { "Aktivitet_AktivitetID" });
            DropIndex("dbo.Aktivitet", new[] { "AktivitetID" });
            DropPrimaryKey("dbo.PersonalAktivitet");
            AlterColumn("dbo.PersonalAktivitet", "Aktivitet_AktivitetID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Aktivitet", "Namn", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Aktivitet", "AktivitetID", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.PersonalAktivitet", "Aktivitet_AktivitetID1");
            AddPrimaryKey("dbo.PersonalAktivitet", new[] { "Personal_PersonalID", "Aktivitet_AktivitetID" });
            AddPrimaryKey("dbo.Aktivitet", new[] { "AktivitetID", "Namn", "Avdelning_AvdelningID" });
        }
    }
}
